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
| Crude Fishing Rod | Tool — basic fishing, Common-tier catches only (16-resources-and-materials.md, 16.2) |
| Crude Net | Tool — basic bug-catching, Common-tier catches only (16-resources-and-materials.md, 16.2) |
| Simple Bandage | Consumable — minor heart/heal restore |
| Basic Fence (short) | Placeable/Building — teaches placement UI, base-marking |
| Torch (handheld) | Tool/Utility — portable light, separate from Campfire |
| Simple Cooking Pot | Placeable/Utility — upgrade path from Campfire cooking |

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
- NPC-given tutorial items (what the first greeter NPC hands over, what the tutorial shopkeeper offers, etc.) are an
  intentionally open category — to be detailed alongside the Interactive NPC roster and event-trigger work.
