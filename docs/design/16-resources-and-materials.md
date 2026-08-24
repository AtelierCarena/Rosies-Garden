# 16. Resources and Materials

Fills a gap left open by the Forge/Craft skill tree (3.7, "tool/weapon quality" progression) and several already-
locked NPCs/zones that depend on raw materials existing: Barrow (Miner/Prospector), Gideon and August (Forge/
Carpenter), the Quarry, the Forest and Hidden Forest (15.1). All names made up to fit the world rather than generic
real-world material names.

## 16.1 Wood — Cosmetic Only, Species Variety
Wood affects **only the color/style of furniture and structures built with it** — no stats, no durability, no
gameplay function beyond appearance (see 07-item-system.md, 8.2 for the durability rule this excludes wood from).
Modeled after Minecraft's wood-species approach rather than a power ladder: many distinct tree species exist purely
to give builders visual choice, none "better" than another. Gathered with the Axe (9.1) from Timber Trees, distinct
from the food-producing Fruit/Nut/Maple orchard trees in 14.6.

| Wood | Source Tree | Look |
|---|---|---|
| Palewood | Palewood Tree | Light, pale |
| Duskoak | Duskoak Tree | Warm mid-brown |
| Briarwood | Briarwood Tree | Gnarled, dark reddish |
| Silverbark | Silverbark Tree | Pale, silvery-white |
| Emberheart Wood | Emberheart Tree | Deep red, glowing grain |
| Sunwillow | Sunwillow Tree | Golden-yellow |
| Ashgrove | Ashgrove Tree | Cool grey-toned |

All seven are gathered the same way and are equally available — there's no rarity/unlock ladder to climb through.
Which tree is found where is a geography/flavor question, not a progression one.

## 16.2 Ore — 5 Tiers, Escalating Power — Locked
Unlike wood, ore genuinely gets stronger with each tier — this is what feeds the Durability rule for Tools and
Weapons/Armor (07-item-system.md, 8.2). Sourced from the Quarry (15.1) and mining nodes inside the dungeon. Ties to
Barrow's role (12-npc-roster.md) and Forge recipes (3.7).

| Tier | Ore | Notes |
|---|---|---|
| 1 | Coppervein Ore | Common, near-surface Quarry ore — starting-tier |
| 2 | Ironshale Ore | Denser, standard mid-tier |
| 3 | Duskmetal Ore | Rarer, subtle blue-black sheen, found deeper |
| 4 | Moonsilver Ore | Rare, faintly glowing pale ore — plausible Arcane/enchanting crossover material |
| 5 | Thornsteel Ore | Rarest, found only at the dungeon's deepest brackets — top-tier weapon/armor material, echoing the thorn motif already running through the world (Thorne, the dungeon bracket names, etc.) |

**Quarry spawn rule — Locked:** the Quarry only spawns ore tiers the player has already discovered inside the
dungeon. Each tier must first be found on a dungeon mining node before the Quarry starts spawning it too, at a
tiered spawn-rate chance (lower tiers common, higher tiers rare, once unlocked). This mirrors the "informationally
known before physically/safely available" discovery pattern already established elsewhere — Wild Spawns (9.3), new
crops via Percival (14.2) — the dungeon is where an ore is first proven to exist; the Quarry becomes the safer,
repeatable source afterward.

## 16.3 Fiber Plants (for Cloth) — Locked

| Tier | Fiber | Source | Notes |
|---|---|---|---|
| Basic | Flaxwisp | Farmable plant | Standard cloth fiber — base-tier Clothing/Cosmetics material for Seraphina's shop |
| Premium | Silkveil Moss | Wild-foraged (damp/shaded zones — Hidden Forest, the Bay) | Finer, luxurious thread for higher-tier cosmetic Clothing |

**Mixed-ingredient crafting — Locked, cloth-specific:** any cloth recipe requiring multiple fiber units can be
satisfied by mixing Flaxwisp and Silkveil Moss in any combination, rather than requiring a single specific
ingredient — a 2-fiber recipe accepts 2 Flaxwisp, 2 Silkveil Moss, or 1 of each. This substitution flexibility is
scoped to cloth only for now, not a universal crafting rule applied across other material categories.

## 16.4 Open Questions
- Exact gathering tools/skill-tree gating per ore tier (does mining a higher tier require a better Pickaxe, per the
  Tier-Unlocked pattern in 3.6, or is it purely location/discovery-gated per 16.2's Quarry rule?).
- Sell prices and crafting-recipe material costs (ore, wood, and fiber alike).
- Exact durability numbers per ore tier (the rule that durability scales with ore tier is locked per 8.2; the actual
  numbers are not).
- Whether the mixed-ingredient crafting rule (16.3) should ever extend beyond cloth.
