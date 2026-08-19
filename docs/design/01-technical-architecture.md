# 2. Technical Architecture

## 2.1 Engine Recommendation: Unity
Given the PC + Console + Mobile target, Unity is recommended over Godot or Unreal for this project.

- **Console certification:** mature, well-documented submission paths for PlayStation / Xbox / Switch, versus Godot
  typically needing third-party middleware for console export.
- **Mobile pipeline:** the most mature of the three engines for 2D mobile games (touch input, IL2CPP builds,
  performance profiling).
- **Multiplayer tooling:** Netcode for GameObjects or Mirror both handle host-based and client-server online play well,
  with strong prior art in the cozy-farming-sim-with-co-op genre.
- **2D top-down tooling:** first-party Tilemap system, 2D lighting (URP), and sprite/animation tools.

Godot remains a strong alternative (lighter, free, arguably nicer 2D workflow) but console certification tips the decision
toward Unity given the three-platform target.

## 2.2 Architecture Split
**Shared foundation** (used identically by all three modes): world generation and save data format; core gameplay
systems (inventory, crafting, building placement, combat, farming, day/night cycle) written network-agnostic, so
gameplay logic never needs to know whether it is running locally or online.

| Mode | Implementation |
|---|---|
| Solo | Single local input, single camera, no network layer at all. |
| Split-Screen | Multiple local inputs (gamepad-per-player recommended), multiple cameras rendering the same local game state. No netcode required — one machine, one save file. |
| Online | Netcode layer (Netcode for GameObjects / Mirror) synchronizing state across machines, with a host or dedicated server as the authoritative source of truth. |

**Design discipline:** gameplay systems are written once; split-screen vs. online is an input/camera/networking wrapper
difference, not duplicated game logic.

## 2.3 Split-Screen Specifics
- Up to 4 players. Camera dynamically splits based on player distance (similar to Rayman Legends / It Takes Two) —
  players near each other share one zoomed viewport; players who separate trigger a live split into independent
  viewports.
- Players roam independently; base/build locations are their own choice, not fixed to a shared camera.
- Worst case (4-way split) is a quad-split viewport and roughly 4x the per-frame render cost of solo play. **Open flag:**
  mobile may need a lower split-screen player cap (e.g. 2) given screen space and performance headroom — not yet
  decided; see Parking Lot.

## 2.4 Camera: Stardew Valley Style
The main-world camera uses Stardew Valley's **fixed 3/4 overhead angle** — not a literal straight-down minimap view.
Sprites (trees, buildings, the player) are billboarded flat 2D art drawn to show their "front faces" even though the
camera is looking down at the world, which is what gives Stardew's world its sense of volume without any real camera
tilt or 3D geometry. Don't Starve Together is no longer a camera reference; its influence is now scoped strictly to item
progression and machine-gated crafting (see 3.6). Overall art style otherwise draws from Stardew Valley, Moonlighter,
and especially Sun Haven (to be finalized once visual reference images are gathered).

## 2.5 Spawning, Bases, and Chests
- Multiplayer players spawn within a 50-block radius of one another.
- Each player can build their own individual base.
- Chests can be shared or locked to their builder — supporting both cooperative and private inventory management.
  Data model: chest carries an `owner_id` and a `locked` flag with a UI toggle.
- In Online mode, lock/unlock actions are server-authoritative (validated server-side) so a client cannot spoof access
  to another player's locked chest. Solo and Split-Screen share local state directly.

## 2.6 Elevation and Terraforming: Animal Crossing Style
World height uses **discrete tiers, not true voxel verticality**. A handful of stacked height layers (ground level, one
or two cliff tiers above, mine/dungeon floors below) connected by ramps, stairs, and waterfalls — the same technique
Stardew Valley's own mine levels and Rune Factory already use on a 2D engine, and the model Animal Crossing: New
Horizons uses for its cliff terraforming tool. The player can reshape a tier's edges (raise/lower cliff faces, place
ramps, redirect water) but there's no free-form Y-axis stacking or digging straight down through arbitrary space.

This is a deliberate scope cut from Minecraft's literal voxel verticality: true 3D block-stacking under a 2D-presented
camera is a genuinely hard engineering problem (3D collision, lighting, chunk streaming) that isn't a good fit for this
project. Minecraft's contribution to the design stays scoped to freeform build-anywhere placement and crafting-driven
creativity (per 1.2) — the *feeling* of build freedom, delivered through terraforming tiers and unrestricted horizontal
placement rather than infinite height.
