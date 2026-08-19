# 1. Concept Overview

## 1.1 Elevator Pitch
An adorable, coquette-styled top-down adventure and building game blending cozy farming/social-sim systems with
crafting depth, dungeon-crawling stakes, and shop-keeping economics — wrapped in a soft, romantic aesthetic. Players
choose Solo, Split-Screen, or LAN/Internet multiplayer at save creation.

## 1.2 Inspiration Map

| Inspiration | Contributes |
|---|---|
| Stardew Valley | Farming loop, NPC relationships and gift-giving, daily/seasonal rhythm, and the fixed 3/4 camera angle (see 2.4) |
| Minecraft | Freeform construction and building-driven creativity ONLY — not literal voxel/height verticality, see 2.6 |
| Animal Crossing: New Horizons | Tiered terraforming — cliffs, ramps/stairs, waterfalls connecting discrete height layers (see 2.6) |
| Sun Haven | Fantasy/magic layer, companions, overall art-style inspiration |
| Moonlighter | Dungeon-crawling-for-profit loop, shop-keeping mechanics, art-style inspiration |
| Don't Starve Together | Item progression and machine mechanics ONLY — the machine-unlocks-recipes crafting logic. Explicitly NOT survival mechanics, and NOT the camera — see 1.3. |

## 1.3 Important Correction: This Is Not a Survival Game
Don't Starve Together's influence is strictly limited to its "build the machine to unlock the recipe tier" crafting logic.
There are **no hunger, sanity, or survival meters**, and the camera is not DST-style either (see 2.4 — the main world
uses Stardew Valley's fixed 3/4 overhead perspective). Core gameplay pulls from Stardew Valley and
Moonlighter instead: the player has a Hearts-based health system, and losing all hearts results in being
**knocked out** and relocated to the Town Hospital or the player's Homestead — never a fail state or permanent death.

## 1.4 Game Modes (chosen at save file creation)

| Mode | Description |
|---|---|
| Solo | Single player, single screen. |
| Multiplayer — Split-Screen | Local multiplayer, up to 4 players, dynamic camera splitting. **PC and Console only — not offered on mobile** (see 2.3). |
| Multiplayer — LAN / Internet | Netcode-based co-op, up to 6 players, over a local network or the internet. The only options for a 5-6 player save file, since Split-Screen caps at 4. |

The overall player cap is 6, but not every mode supports it: Split-Screen tops out at 4 players (and isn't available
on mobile at all), while LAN and Internet support the full 6. A save file created for 5 or 6 players is LAN/Internet
only — there's no split-screen fallback at that size.

Split-Screen and LAN/Internet play are deliberately kept as two separate, non-interchangeable setup-time
configurations rather than one unified system — attempting to serve both with the same underlying
netcode/rendering approach would compromise both. Each save file is tagged with its mode (solo / splitscreen /
lan / online) at creation and does not migrate between modes.
