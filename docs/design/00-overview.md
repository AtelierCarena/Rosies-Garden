# 1. Concept Overview

## 1.1 Elevator Pitch
An adorable, coquette-styled top-down adventure and building game blending cozy farming/social-sim systems with
crafting depth, dungeon-crawling stakes, and shop-keeping economics — wrapped in a soft, romantic aesthetic. Players
choose Solo, Split-Screen, or Internet multiplayer at save creation.

## 1.2 Inspiration Map

| Inspiration | Contributes |
|---|---|
| Stardew Valley | Farming loop, NPC relationships and gift-giving, daily/seasonal rhythm |
| Minecraft | Freeform construction, resource gathering, building-driven creativity |
| Sun Haven | Fantasy/magic layer, companions, overall art-style inspiration |
| Moonlighter | Dungeon-crawling-for-profit loop, shop-keeping mechanics, art-style inspiration |
| Don't Starve Together | Camera work ONLY (fixed-angle pseudo-3D) and the machine-unlocks-recipes crafting logic. Explicitly NOT survival mechanics — see 1.3. |

## 1.3 Important Correction: This Is Not a Survival Game
Don't Starve Together's influence is strictly limited to (a) its fixed-angle camera perspective and (b) its "build the
machine to unlock the recipe tier" crafting logic. There are **no hunger, sanity, or survival meters**. Core gameplay pulls
from Stardew Valley and Moonlighter instead: the player has a Hearts-based health system, and losing all hearts results
in being **knocked out** and relocated to the Town Hospital or the player's Homestead — never a fail state or permanent
death.

## 1.4 Game Modes (chosen at save file creation)

| Mode | Description |
|---|---|
| Solo | Single player, single screen. |
| Multiplayer — Split-Screen | Local multiplayer, up to 4 players, dynamic camera splitting. |
| Multiplayer — Internet | Online co-op via netcode, up to 4 players. |

Split-Screen and Internet play are deliberately kept as two separate, non-interchangeable setup-time configurations
rather than one unified system — attempting to serve both with the same underlying netcode/rendering approach would
compromise both. Each save file is tagged with its mode (solo / splitscreen / online) at creation and does not migrate
between modes.
