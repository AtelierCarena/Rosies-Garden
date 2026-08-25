# 9. Starting Experience

## 9.1 Universal Starting Inventory
Every player, regardless of chosen Combat Class, begins with:

| Item | Notes |
|---|---|
| Hoe | Farming |
| Axe | Gathering |
| Watering Can | Dual-function: waters crops, AND grows traversal flora — used on a flowerbed at the base of a cliff to sprout a large flower the player can climb up and down, gating elevation-based exploration behind the farming toolkit itself. |
| A few placeable Torches | Can be placed in the world as a light source, OR equipped in the off-hand to auto-light the player's path while walking. Press L to place a torch from the off-hand. |
| Map | See 9.3. |
| Class Weapon, Light Clothing, Light Armor | Determined by chosen Combat Class — see Section 10. |
| Small amount of Food | Healing/buff item — not a depleting hunger meter (see 1.3). |

## 9.2 Default Hand-Craftables (Tier 0 — No Station, No Points Required)
A universal baseline every character knows regardless of build, sitting below Tier 1 of every skill tree:

| Item | Category |
|---|---|
| Campfire | Placeable/Utility — light source, basic cooking |
| Basic Storage Chest | Placeable/Storage |
| Crude Pickaxe | Tool — basic mining |
| Crude Axe | Tool — basic wood-gathering |
| Simple Bandage | Consumable — minor heart/heal restore |
| Basic Fence (short) | Placeable/Building — teaches placement UI, base-marking |
| Torch (handheld) | Tool/Utility — portable light, separate from Campfire |
| Simple Cooking Pot | Placeable/Utility — upgrade path from Campfire cooking |

**Deliberately not here: the Fishing Rod and Net.** Unlike the rest of this table, fishing/bug-catching tools are
NPC-granted rather than universal-from-start — see 9.5, Silas's Fishing Lesson.

## 9.3 Map System
- Starts as a physical inventory item. On FIRST open, it leaves the inventory permanently and becomes a persistent
  small UI element (corner minimap) — a one-way conversion.
- Pressing M expands the minimap into a full-screen map view for navigation.
- **Visibility:** rough outlines/regions are visible from the start (general shapes); details stay fogged until physically
  explored. Once revealed, detail is permanent (does not re-fog).
- **Player-placed pins:** free custom placement with an icon and optional note.
- **Toggleable auto-layers:** Quest markers (dynamic), Landmarks (permanent once discovered), Resource
  discovery locations (permanent once discovered), and Wild Spawn/Seasonal Zones (see below).

### Wild Spawn Icon States (seasonal resource zones, e.g. a spring onion patch or a salmon run)

| Icon State | Meaning |
|---|---|
| Opaque / solid icon | Currently active spawn for the CURRENT season, previously discovered. |
| Transparent / ghostly icon | Known to be active NEXT season — either physically found during that season in a prior cycle, OR learned secondhand (NPC dialogue, books, lore) without ever having visited during its active window. Lets a player prepare up to one season in advance. |
| No icon shown | Never discovered by any means. |

**Data implication:** each wild spawn location needs two independent flags — `physically_discovered` and
`informationally_known` — since a player could learn about a spawn from a book before ever finding it in person. This
rewards NPC relationships and reading with a genuine gameplay planning advantage.

## 9.4 Tutorial Tone and First Companion
- Tutorial guidance is MODERATE — clear objectives, but not overly scripted, leaving room for organic discovery
  (like Rose's chain) to feel special rather than pointed-at.
- The player's first companion is earned/found during early gameplay rather than gifted at the very start.
- NPC-given tutorial items are an intentionally open category overall (to be detailed alongside the rest of the
  Interactive NPC roster and event-trigger work), **except fishing, which is now fully specified** — see 9.5, the
  first worked example of this pattern.

## 9.5 Silas's Fishing Lesson — Locked, worked example
The Fishing Rod and Net are deliberately withheld from the universal starting kit (9.2) and instead granted through
an actual NPC introduction — the first fully-specified instance of the "NPC-given tutorial item" pattern flagged
above, and a template for how other NPCs' starter-item events should be built.

**Three trigger paths, player-driven — Locked:**
1. **Visit the Dock** and find Silas there during the day.
2. **Visit the Tavern at night** and find Silas there instead.
3. **Do neither for 3 in-game days** after starting the save — a letter arrives, in-fiction explained as Olivier
   (the Mayor) having mentioned the player to Silas, inviting them down to the Dock to learn fishing. This is a
   nudge, not an auto-trigger: the letter only tells the player where to go — **the player still has to physically
   go meet him** to actually receive the lesson. Nothing fires automatically.

All three paths lead to the same lesson/reward once triggered — the Dock and Tavern paths are just organic
discovery routes that pre-empt the letter nudge, matching the MODERATE tutorial tone above (clear enough that no
player gets stuck without ever fishing, loose enough to reward exploration over hand-holding).

**What the lesson grants, all at once:**

| Item | Type |
|---|---|
| 1x Crude Fishing Rod | Physical tool — the actual starting Rod |
| Recipe: Crude Fishing Rod | So the player can craft replacements/rebuilds later |
| Recipe: Fishing Net | Bug-catching tool, same Tier 0/Crude tier as the Rod (16-resources-and-materials.md, 16.2) |
| Recipe: Lobster Trap | The passive catch-tool named in 16.2's tool-gating table |
| Recipe: Common Fishing Bait | See below |
| Worm Gathering | Unlocks digging Worms from randomly spawning "soft spots" in the dirt — see below |

**Fishing Bait — Locked, new consumable.** A per-cast consumable distinct from Rod tier: Bait improves catch-chance
within whatever rarity range the equipped Rod can already reach, but never raises the max catchable rarity the way
a better Rod does (16.2's tier table still hard-gates that). Common Fishing Bait is the Tier 0 baseline recipe
granted here; higher Bait tiers are a plausible future Trade/Forge unlock, not detailed yet.

**Worms and Soft Spots — Locked, new gatherable.** Small, randomly-spawning "soft spot" markers appear in diggable
dirt across the overworld — not season-locked, not tied to a fixed Wild Spawn zone (9.3), just a background
random-spawn layer the player learns to notice once Silas teaches them what to look for. Digging a soft spot
yields Worms, the base ingredient for Common Fishing Bait and a plausible Lobster Trap ingredient. Sell
price/exact spawn rate TBD.
