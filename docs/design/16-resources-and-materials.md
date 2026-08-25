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

| Wood | Source Tree | Look | Sell Price |
|---|---|---|---|
| Palewood | Palewood Tree | Light, pale | 5g |
| Duskoak | Duskoak Tree | Warm mid-brown | 5g |
| Briarwood | Briarwood Tree | Gnarled, dark reddish | 5g |
| Silverbark | Silverbark Tree | Pale, silvery-white | 5g |
| Emberheart Wood | Emberheart Tree | Deep red, glowing grain | 5g |
| Sunwillow | Sunwillow Tree | Golden-yellow | 5g |
| Ashgrove | Ashgrove Tree | Cool grey-toned | 5g |

All seven are gathered the same way and are equally available — there's no rarity/unlock ladder to climb through.
Which tree is found where is a geography/flavor question, not a progression one. Sell price is flat and identical
across all seven, reinforcing that none is "better" than another — the choice is purely aesthetic.

## 16.2 Ore — 5 Tiers, Escalating Power — Locked
Unlike wood, ore genuinely gets stronger with each tier — this is what feeds the Durability rule for Tools and
Weapons/Armor (07-item-system.md, 8.2). Sourced from the Quarry (15.1) and mining nodes inside the dungeon. Ties to
Barrow's role (12-npc-roster.md) and Forge recipes (3.7).

| Tier | Ore | Notes | Sell Price | Base Durability |
|---|---|---|---|---|
| 1 | Rosevein Ore | Common, near-surface Quarry ore — starting-tier | 15g | 50 |
| 2 | Ashenshale Ore | Denser, standard mid-tier | 40g | 100 |
| 3 | Duskmetal Ore | Rarer, subtle blue-black sheen, found deeper | 90g | 180 |
| 4 | Moonsilver Ore | Rare, faintly glowing pale ore — plausible Arcane/enchanting crossover material | 200g | 300 |
| 5 | Thornsteel Ore | Rarest, found only at the dungeon's deepest brackets — top-tier weapon/armor material, echoing the thorn motif already running through the world (Thorne, the dungeon bracket names, etc.) | 450g | 500 |

**Rosevein** ties into the Rose Garden imagery already anchoring the dungeon's first bracket (10-dungeons-and-risk.md,
11.2); **Ashenshale** carries the same faint decay/weathering thread running through the wood species (Ashgrove) and
the dungeon's ash-and-rot tone, without literally reusing that name.

**Quarry spawn rule — Locked:** the Quarry only spawns ore tiers the player has already discovered inside the
dungeon. Each tier must first be found on a dungeon mining node before the Quarry starts spawning it too, at a
tiered spawn-rate chance (lower tiers common, higher tiers rare, once unlocked). This mirrors the "informationally
known before physically/safely available" discovery pattern already established elsewhere — Wild Spawns (9.3), new
crops via Percival (14.2) — the dungeon is where an ore is first proven to exist; the Quarry becomes the safer,
repeatable source afterward.

**Pickaxe tier-gating — Locked:** discovery (above) controls when an ore tier exists in the world; the player's
Pickaxe tier controls whether *they* can extract it once discovered, via the same Tier-Unlocked pattern used
elsewhere in Forge/Craft (02-skill-trees.md, 3.6). A Tier 1 Pickaxe can only mine Rosevein; each Pickaxe tier
unlocks mining of the next ore tier up, 1:1, so a player can see a higher-tier node before they're equipped to
harvest it.

**Fishing Rod / Net / Trap tier-gating — Locked:** the same pattern extends to catching Fish and Bugs
(14-plants-and-crops.md, 14.5). Each tool is crafted at the matching Ore tier and gates two things at once: the
**maximum rarity tier catchable at all**, and a **per-tier bonus to catch-chance/minigame ease** within whatever
range that tool can already reach. A Tier 1 Rod simply cannot hook a Rare fish — the creature won't bite at all —
rather than offering a harder chance at it.

| Ore Tier | Rod/Net/Trap Tier | Max Catchable Rarity | Catch-Chance Bonus |
|---|---|---|---|
| 1 (Rosevein) | Crude | Common | — (baseline) |
| 2 (Ashenshale) | Tier 2 | Uncommon | +10% |
| 3 (Duskmetal) | Tier 3 | Rare | +20% |
| 4 (Moonsilver) | Tier 4 | Epic | +30% |
| 5 (Thornsteel) | Tier 5 | Legendary | +40% |

Applies uniformly to overworld, Event, and dungeon-exclusive Fish/Bugs alike (14.5) — reaching the Cradle
Graveyard's Legendary-tier catches, or a Snowbound Anglerfish, requires a Tier 5 Rod regardless of where the
creature is found. The bonus is a flat improvement to the timed-minigame catch window/bite rate (14.5's Catch
Mechanic), not a separate roll — a better tool makes catches within its range easier, not just unlocks new ranges.

**Three distinct tools, one shared ladder:**
- **Fishing Rod** — active, used at water, catches Fish. The player engages the timed bar-alignment minigame.
- **Net** — active, used on land/air, catches Bugs. The player engages the timed positioning/swing minigame.
- **Trap** — passive, placed near a Fish or Bug spawn zone and left to work over one in-game day/night cycle, no
  minigame required. Trades the active tools' catch-chance bonus for zero player time cost — a Trap only ever
  catches at its tier's baseline chance (no +10%/+20%/etc. bonus), regardless of Trap tier, since the tradeoff is
  convenience, not power. Higher Trap tiers still raise the max catchable rarity, same as Rod/Net.

Crude versions of the Rod and Net are part of the Tier 0 hand-craftable baseline (08-starting-experience.md, 9.2) —
every player starts able to fish/net Common-tier creatures immediately, mirroring the Crude Pickaxe/Crude Axe
pattern already established there. The Trap is a Forge/Craft Tier 1 unlock rather than a Tier 0 hand-craftable,
since passive automation is a step up from the immediate-use starting toolkit.

## 16.3 Fiber Plants (for Cloth) — Locked

| Tier | Fiber | Source | Notes | Sell Price |
|---|---|---|---|---|
| Basic | Flaxwisp | Farmable plant | Standard cloth fiber — base-tier Clothing/Cosmetics material for Seraphina's shop | 8g |
| Premium | Silkveil Moss | Wild-foraged (damp/shaded zones — Hidden Forest, the Bay) | Finer, luxurious thread for higher-tier cosmetic Clothing | 25g |

**Mixed-ingredient crafting — Locked, cloth-specific:** any cloth recipe requiring multiple fiber units can be
satisfied by mixing Flaxwisp and Silkveil Moss in any combination, rather than requiring a single specific
ingredient — a 2-fiber recipe accepts 2 Flaxwisp, 2 Silkveil Moss, or 1 of each. This substitution flexibility is
scoped to cloth only for now, not a universal crafting rule applied across other material categories.

## 16.4 Open Questions
- Crafting-recipe material costs (how much ore/wood/fiber a given recipe consumes) — sell prices themselves are now
  locked (16.1-16.3), but recipe costs are a separate, still-open question.

**Resolved:**
- Gathering gate — both discovery (Quarry only spawns a tier once found in the dungeon, 16.2) and Pickaxe tier
  (Tier-Unlocked pattern, 3.6) apply, stacked.
- Sell prices — locked, see 16.1-16.3 tables.
- Durability numbers per ore tier — locked, see 16.2 table; Enchantment scaling locked in 07-item-system.md, 8.2.
- Mixed-ingredient crafting (16.3) stays scoped to cloth only — ore tiers are deliberately non-interchangeable
  (16.2's whole premise is that higher tiers are strictly better), so extending substitution there would undercut
  the tier progression durability and combat power are built on.
