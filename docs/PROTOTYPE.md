# Prototype: Vertical Slice 0 — Movement & Camera

Goal: prove the core world feel — a player moving around a world with Stardew Valley's fixed 3/4 overhead camera
(see [`docs/design/01-technical-architecture.md`](design/01-technical-architecture.md), 2.4). This is scoped to
movement + camera only; farming, combat, building, and terraforming come later.

This repo doesn't carry a checked-in Unity install, so the scene/prefab assembly below is a manual editor step the
first time someone opens the project. The scripts are already written and just need wiring up.

## Requirements
- Unity 2022 LTS (or newer) with 2D URP template support.
- Packages already declared in `Packages/manifest.json`: URP, 2D Tilemap, 2D Sprite, Input System, Netcode for
  GameObjects (unused this slice, but declared per the architecture doc).

## Scripts in this slice
| Script | Path | Purpose |
|---|---|---|
| `PlayerController` | `Assets/_Project/Scripts/Player/PlayerController.cs` | 8-directional top-down movement via the new Input System. |
| `TopDownCameraFollow` | `Assets/_Project/Scripts/Camera/TopDownCameraFollow.cs` | Orthographic follow camera, untilted (the 3/4 look comes from sprite art, not camera rotation). Optional world-bounds clamp. |
| `HeartsHealth` | `Assets/_Project/Scripts/Core/HeartsHealth.cs` | Hearts meter stub (no death — see design doc 1.3) so damage/knockout hookups have somewhere to land later. |

## Setup steps
1. **Project Settings → Player**: confirm Active Input Handling is set to "Input System Package (New)" or "Both".
2. **Create an Input Actions asset** (`Assets/_Project/Input/PlayerControls.inputactions`) with:
   - Action Map `Player`
   - Action `Move` (Vector2 / 2D Vector composite), bound to WASD + left stick.
3. **Scene**: create `Assets/_Project/Scenes/Prototype_World.unity`.
   - Set `Main Camera` to **Orthographic**, size ~5 (tune to sprite pixel density), rotation `(0, 0, 0)` — the camera
     itself stays untilted; Stardew's characteristic 3/4 look comes from how the sprite art is drawn (billboarded
     "front faces"), not from rotating the camera.
   - Add `TopDownCameraFollow` to the Main Camera.
4. **Player object**: empty GameObject named `Player` with:
   - `SpriteRenderer` (placeholder square/capsule sprite is fine for this slice)
   - `Rigidbody2D` (gravity scale 0 — handled in code, but set it in the inspector too as a safety default)
   - `CapsuleCollider2D` or `BoxCollider2D`
   - `PlayerInput` component, wired to the `PlayerControls` asset, Behavior = "Send Messages" (matches
     `OnMove(InputValue)` in `PlayerController`)
   - `PlayerController` script
   - `HeartsHealth` script
5. **Wire the camera to the player**: on `TopDownCameraFollow`, drag the `Player` transform into the `Target` field
   (or call `SetTarget` from a bootstrap script at scene start once spawning exists).
6. **Ground**: a `Tilemap` (Grid → 2D Object → Tilemap → Rectangular) with a placeholder ground tile, big enough to
   walk around in, so movement has somewhere to happen and the camera has something to frame.

## Done when
- Pressing WASD/left-stick moves the player smoothly in 8 directions.
- The camera tracks the player smoothly with no rotation/tilt applied to the camera itself.
- No console errors on entering Play mode.

## Not in scope for this slice
Farming, combat, building placement, split-screen/online modes, DST-style machine crafting, and the tiered
terraforming/elevation system (see [01-technical-architecture.md, 2.6](design/01-technical-architecture.md)). Those
land in later slices once movement + camera are validated.
