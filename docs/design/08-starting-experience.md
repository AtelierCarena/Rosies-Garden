# 9. Starting Experience

## 9.1 Universal Starting Inventory
Every player, regardless of chosen Combat Class, begins with:

| Item | Notes |
|---|---|
| Hoe | Farming |
| Crude Axe | Gathering — matches the Tier 0 hand-craftable of the same name (9.2); listed here since every player also starts with one on hand, not just the recipe |
| Watering Can | Dual-function: waters crops, AND grows traversal flora — used on a flowerbed at the base of a cliff to sprout a large flower the player can climb up and down, gating elevation-based exploration behind the farming toolkit itself. |
| A few placeable Torches | Can be placed in the world as a light source, OR equipped in the off-hand to auto-light the player's path while walking. Press L to place a torch from the off-hand. |
| Class Weapon, Light Clothing, Light Armor | Determined by chosen Combat Class — see Section 10. |
| Small amount of Food | Healing/buff item — not a depleting hunger meter (see 1.3). |

**Deliberately not here: the Map and Pickaxe.** Both are delivered together via a guaranteed Day 1 event rather
than silently sitting in the starting inventory — see 9.8, Barrow's Doorstep Note.

## 9.2 Default Hand-Craftables (Tier 0 — No Station, No Points Required)
A universal baseline every character knows regardless of build, sitting below Tier 1 of every skill tree:

| Item | Category |
|---|---|
| Campfire | Placeable/Utility — light source, basic cooking |
| Basic Storage Chest | Placeable/Storage |
| Crude Axe | Tool — basic wood-gathering |
| Simple Bandage | Consumable — minor heart/heal restore |
| Basic Fence (short) | Placeable/Building — teaches placement UI, base-marking |
| Torch (handheld) | Tool/Utility — portable light, separate from Campfire |
| Simple Cooking Pot | Placeable/Utility — upgrade path from Campfire cooking |

**Deliberately not here: the Fishing Rod, Net, and Pickaxe.** Unlike the rest of this table, fishing/bug-catching/
mining tools are NPC-granted rather than universal-from-start — see 9.5 (Silas), 9.6 (Linnet), and 9.8 (Barrow).

## 9.3 Map System
- Delivered to the player on Day 1 via Barrow's Doorstep Note (9.8), not silently placed in the starting
  inventory. Starts as a physical inventory item from that point. On FIRST open, it leaves the inventory
  permanently and becomes a persistent small UI element (corner minimap) — a one-way conversion.
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
  Interactive NPC roster and event-trigger work), **except fishing/bug-catching/taming, which are now fully
  specified** — see 9.5-9.7, split across the three NPCs whose trades actually match each tool.

## 9.5 Silas's Fishing Lesson — Locked, worked example
The Fishing Rod is deliberately withheld from the universal starting kit (9.2) and instead granted through an
actual NPC introduction — the first fully-specified instance of the "NPC-given tutorial item" pattern flagged
above, and the template 9.6-9.7 reuse for Linnet and Beau.

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

**What the lesson grants, all at once — revised, fishing-only:**

| Item | Type |
|---|---|
| 1x Crude Fishing Rod | Physical tool — the actual starting Rod |
| Recipe: Crude Fishing Rod | So the player can craft replacements/rebuilds later |
| Recipe: Lobster Trap | The passive catch-tool named in 16.2's tool-gating table — stays with Silas since lobsters are a Dock/water creature, squarely his domain |
| Recipe: Common Fishing Bait | See below |
| Worm Gathering | Unlocks digging Worms from randomly spawning "soft spots" in the dirt — see below |

The **Fishing Net recipe moved to Linnet (9.6)** and a **new Animal Trap recipe moved to Beau (9.7)** — splitting
what was originally one oversized bundle across the three NPCs whose actual trades match each tool, rather than
one fisherman teaching bug-catching and animal-taming too.

**Fishing Bait — Locked, new consumable.** A per-cast consumable distinct from Rod tier: Bait improves catch-chance
within whatever rarity range the equipped Rod can already reach, but never raises the max catchable rarity the way
a better Rod does (16.2's tier table still hard-gates that). Common Fishing Bait is the Tier 0 baseline recipe
granted here; higher Bait tiers are a plausible future Trade/Forge unlock, not detailed yet.

**Worms and Soft Spots — Locked, new gatherable.** Small, randomly-spawning "soft spot" markers appear in diggable
dirt across the overworld — not season-locked, not tied to a fixed Wild Spawn zone (9.3), just a background
random-spawn layer the player learns to notice once Silas teaches them what to look for. Digging a soft spot
yields Worms, the base ingredient for Common Fishing Bait and a plausible Lobster Trap ingredient. Sell
price/exact spawn rate TBD.

## 9.6 Linnet's Bug-Catching Lesson — Locked
Reuses Silas's event template (9.5): triggered the first time the player encounters Linnet at her hives, granting
the Fishing Net recipe (Tier 0/Crude tier, 16-resources-and-materials.md, 16.2) along with a short lesson in
reading the same shadow/movement "approach" cues used for the overworld catch mechanic (14-plants-and-crops.md,
14.5), just applied to insects instead of fish. Simpler single-encounter trigger than Silas's three-path system,
since bug-catching isn't the player's very first tool and doesn't need the same amount of tutorial scaffolding.

## 9.7 Beau's Taming Lesson — Locked
Also reuses Silas's event template: triggered the first time the player visits Beau at the Pen/Coop, granting the
recipe for the new **Animal Trap** (below) plus a short lesson in the Wild/Beast taming basics (04-companions.md).
Single-encounter trigger, same reasoning as 9.6.

**Animal Trap — Locked, new item, distinct from the Lobster Trap.** Not a catch-tool for Fish/Bugs — a live-catch
trap used to tame small wild creatures into Tamed Companions (04-companions.md), tying the Wild/Beast tree's
existing taming mechanic to an actual physical tool for the first time. Follows the same Ore-tier ladder as
Rod/Net/Lobster Trap (16.2) — higher tiers raise the maximum "wildness"/rarity of creature that can be safely
tamed with it, mirroring the Rod's max-catchable-rarity gate.

## 9.8 Barrow's Doorstep Note — Locked
Unlike Silas/Linnet/Beau's flexible, player-driven encounters (9.5-9.7), this one is **guaranteed and immediate** —
Barrow has the strongest claim to a starting tool of any NPC (mining is core to Forge/Earth progression from hour
one), so the pattern here is deliberately different: no "go find him," the note comes to the player instead.

**Trigger — Locked:** fires on Day 1, no player action required to start it. A note, a Crude Pickaxe, and the Map
spawn together **directly in front of the player's spawn house door** — physically blocking the exit. This is a
diegetic soft-gate, not an invisible wall: the player must pick up the note (and with it, the Pickaxe and Map) to
clear the doorway and leave the house at all. No player can miss this one.

**What it grants, all at once:**

| Item | Type |
|---|---|
| 1x Crude Pickaxe | Physical tool — the actual starting Pickaxe |
| Recipe: Crude Pickaxe | So the player can craft replacements/rebuilds later |
| Map | Physical item, becomes the persistent minimap on first open (9.3) |
| The Note itself | In-fiction: Barrow, prompted by the Mayor, left this for the new arrival — invites the player down to town to meet him properly |

**No forced follow-up.** The note tells the player where to find Barrow, the same nudge-not-auto-trigger logic
already established for Silas's letter (9.5) — actually walking down to meet him is a narrative/relationship beat
the player can pursue on their own schedule, not a second mechanical gate. The doorstep delivery is what makes the
tools/Map guaranteed; the in-person meeting is optional flavor on top of that.
