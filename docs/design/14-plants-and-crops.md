# 14. Plants and Crops

Builds on 9.3 (Map System) and 3.7 (Earth/Growth tree), both of which already assume a season calendar without ever
formalizing one.

## 14.1 Season Calendar — Locked
Four seasons — Spring, Summer, Fall, Winter — **30 days each** (120-day year). Crops are season-locked by default; a
crop planted outside its season withers. The Greenhouse (Earth tree, Tier 7 — see 3.7) is the existing mechanism
that lifts this restriction, matching its established "unlocks year-round growing" description.

Crops are **not skill-tree gated** — Earth/Growth nodes affect yield, mutation, and terraforming (per 3.7), not
which seeds are purchasable. Availability is governed by season and rarity instead.

## 14.2 Yearly Crop Rotation Growth — Locked
Every in-game year, **3 new crops are added to the rotation** — new seeds become purchasable/discoverable that
weren't available before. This continues through **Year 4** (extended from the original Year 3 cutoff, to match a
farming sim's realistic multi-year playtime), then stops: by Year 5 the crop roster is permanently complete (the
14.3 starting list, plus these 12 crops added across Years 1-4).

Each year's 3 additions land in Spring, Summer, and Fall only — Winter stays untouched across all four years,
reinforcing its intentional scarcity (14.3) and the incentive to invest in the Greenhouse rather than diluting that
design goal with new Winter content.

| Year | Spring | Summer | Fall |
|---|---|---|---|
| 1 | Larkspur | Zinnias | Elderberries |
| 2 | Anemones | Basil | Belladonna |
| 3 | Foxglove | Mint | Wheat |
| 4 | Delphiniums | Cosmos | Ironweed |

A few notes on these picks:
- **Belladonna** continues the "beautiful but dangerous" thread already running through Nightshade Berries (14.4)
  — another strong Alchemy reagent candidate for Mina's shop (8.2).
- **Basil** and **Mint** are the first cooking-herb crops in the roster — plausible ingredients for Delphine (Chef,
  12-npc-roster.md).
- **Wheat** is the roster's first grain/staple crop — useful for baking, and was a genuine gap before this.
- **Delphiniums** double as a small, deliberate nod toward Delphine (Chef, 12-npc-roster.md) without being a literal
  reference.
- **Ironweed** leans into the ore/thorn-adjacent dark palette running through the world (Thornsteel, the dungeon
  bracket names) — a sturdy, hardy fall bloom rather than another delicate flower.

A plausible future hook, still not locked: Percival could be the one who first mentions a new crop exists, before it's
purchasable — same "informationally known before physically available" pattern already established for Wild Spawns
in 9.3.

## 14.3 Farmed Crops (starting roster, expanded)
Leans into the game's soft/floral aesthetic rather than generic fantasy produce — several entries double as
Placeables/Decor material once harvested (8.4) or as gift items for the NPC gift-preference system (4.3). Expanded
from the original starting roster to give crop rotation planning real depth — Spring/Summer/Fall now sit at 9 crops
each, Winter at 6 (still deliberately behind the others, see below).

**Sell prices — Locked.** Farmed crops sit in the Common range (14.5's rarity/price scale, 20-40g) since they're
grow-to-order rather than found — cheaper than wild-foraged (below), which trades reliability for a price bump.

| Season | Crop | Sell Price |
|---|---|---|
| Spring | Strawberries | 20g |
| Spring | Peas | 15g |
| Spring | Tulips | 25g |
| Spring | Rhubarb | 20g |
| Spring | Carrots | 15g |
| Spring | Forget-Me-Nots | 20g |
| Spring | Violets | 25g |
| Spring | Radishes | 15g |
| Spring | Snapdragons | 25g |
| Summer | Tomatoes | 20g |
| Summer | Sunflowers | 25g |
| Summer | Blueberries | 25g |
| Summer | Melon | 30g |
| Summer | Lavender | 25g |
| Summer | Corn | 15g |
| Summer | Zucchini | 20g |
| Summer | Peonies | 30g |
| Summer | Hibiscus | 25g |
| Fall | Pumpkins | 30g |
| Fall | Cranberries | 25g |
| Fall | Amaranth | 20g |
| Fall | Yams | 20g |
| Fall | Chrysanthemums | 25g |
| Fall | Turnips | 15g |
| Fall | Beets | 20g |
| Fall | Black-Eyed Susans | 25g |
| Fall | Acorn Squash | 25g |
| Winter | Winter Roots | 20g |
| Winter | Holly | 25g |
| Winter | Snow Peas | 20g |
| Winter | Frost Lilies | 25g |
| Winter | Parsnips | 15g |
| Winter | Winter Cabbage | 20g |

Winter stays deliberately sparse (6 crops vs. 9 elsewhere) — Winter is meant to be the lean season, encouraging
Greenhouse investment. The gap is narrower than the original 3-vs-6 split (still noticeable, less punishing).

**Yearly additions — sell prices:**

| Year | Crop | Sell Price | Notes |
|---|---|---|---|
| 1 | Larkspur | 25g | |
| 1 | Zinnias | 25g | |
| 1 | Elderberries | 30g | |
| 2 | Anemones | 25g | |
| 2 | Basil | 20g | |
| 2 | Belladonna | 40g | Upper-Common/edge-of-Uncommon — "beautiful but dangerous," priced above its Fall peers |
| 3 | Foxglove | 30g | Another dangerous-beauty crop, priced accordingly |
| 3 | Mint | 20g | |
| 3 | Wheat | 15g | Grain/staple — deliberately the cheapest of the three, matching its bulk-ingredient role |
| 4 | Delphiniums | 25g | Small nod toward Delphine (Chef), without being a literal reference |
| 4 | Cosmos | 25g | |
| 4 | Ironweed | 30g | Sturdy, dark-palette bloom |

**Forget-Me-Nots** are a deliberate echo of the dungeon bracket name (Forget-Me-Not Fields, 10-dungeons-and-risk.md)
— the same flower exists literally in the farmable world, not just as dungeon flavor text.

## 14.4 Wild-Foraged Plants — Revised
Original items, not reused/reskinned from Stardew Valley's forage list (the first draft leaned too hard on that —
Spring Onions was literally the same item). Leans into the coquette-gothic-garden aesthetic instead: real,
evocative flower/plant names that lean a little dark or a little strange, rather than generic real-world forage.
Tied to the Wild Spawn seasonal resource zones from 9.3, with the physically-discovered / informationally-known
flag split applying to each.

**Sell prices — Locked.** Wild-foraged plants sit in the Uncommon range (14.5's scale, 50-90g) — priced above farmed
crops since finding them costs seasonal timing and searching rather than guaranteed farm-plot yield. Nightshade
Berries edges toward Rare given its Alchemy/danger value. Expanded from 3 to **6 per season**, matching the crop
density increase in 14.3 — several new entries feed directly into the Alchemy/Potions system (07-item-system.md,
8.6).

| Season | Wild Plant | Sell Price |
|---|---|---|
| Spring | Bleeding Heart Blossom | 55g |
| Spring | Dew-Kissed Clover | 50g |
| Spring | Sweetpea Vine | 55g |
| Spring | Moonpetal Iris | 65g |
| Spring | Wild Chamomile | 55g |
| Spring | Pixie Cap Mushroom | 60g |
| Summer | Honeysuckle | 50g |
| Summer | Nightshade Berries | 90g |
| Summer | Firefly Nectar | 65g |
| Summer | Sunburst Fern | 60g |
| Summer | Bee Balm | 55g |
| Summer | Glimmerwing Pollen | 70g |
| Fall | Witch Hazel Bark | 75g |
| Fall | Amber Resin | 70g |
| Fall | Thistledown | 50g |
| Fall | Blackthorn Berries | 75g |
| Fall | Faded Marigold | 55g |
| Fall | Rustcap Mushroom | 60g |
| Winter | Frost-Kissed Ivy | 60g |
| Winter | Silverbell Sprigs | 65g |
| Winter | Snowdrop Blossom | 55g |
| Winter | Hoarfrost Lichen | 65g |
| Winter | Widow's Lace | 70g |
| Winter | Pale Frost Moss | 60g |

Nightshade Berries and Witch Hazel Bark are plausible Alchemy reagents (ties to Mina's shop, 8.2's Alchemy
system) rather than pure gift/decor items — their above-average prices reflect that dual value. Most of the new
additions (Moonpetal Iris, Pixie Cap Mushroom, Glimmerwing Pollen, Blackthorn Berries, Rustcap Mushroom, Hoarfrost
Lichen, Pale Frost Moss) are Alchemy-reagent-flavored by design — direct feed material for 8.6's potion roster.

## 14.5 Fish and Bugs
**Design directive:** same correction as 14.4 — stylized, thematic names, not real-world species pulled 1:1 the way
Stardew does.

### Catch Mechanic — Locked
A hybrid of Animal Crossing: New Horizons' tools and Stardew Valley's timed minigame:
- **Approach (ACNH-style):** the creature is physically visible and real-time in the world before any interaction
  starts — a shadow/ripple in the water for fish, a visible moving insect for bugs. No random abstract encounter;
  the player sees it and closes the distance themselves.
- **Catch (Stardew-style):** once engaged (rod cast near a fish's shadow; net swing timed against a bug's movement),
  a timed skill-check determines success — for fish, a Stardew-style bar-alignment minigame; for bugs, a
  positioning/timing window on the net swing. Difficulty of the minigame/timing window scales with the
  creature's rarity tier below.

### Rarity Tiers and Sell Prices — Suggested
Reuses the existing rarity scale from 8.1 rather than inventing a separate one, so fish/bugs slot into the same
economy logic as everything else:

| Rarity | Suggested Sell Price |
|---|---|
| Common | 20-40g |
| Uncommon | 50-90g |
| Rare | 100-180g |
| Epic | 200-350g |
| Legendary | 500g+ |

### Fish — Expanded
Ties to Silas's Fisherman role and the fishing Shared Activity (4.3). Freshwater-flavored given Silas is
docks/riverside-based. Expanded to **6 regular entries per season**, and each season keeps at least one Common-tier
entry so new/casual anglers always have an easy catch available.

| Season | Fish | Rarity | Sell Price |
|---|---|---|---|
| Spring | Glassfin Minnow | Common | 25g |
| Spring | Petalfin Guppy | Common | 20g |
| Spring | Duckling Fry | Common | 20g |
| Spring | Blushcarp | Uncommon | 60g |
| Spring | Cherryscale Trout | Uncommon | 55g |
| Spring | Willowfin Perch | Uncommon | 65g |
| Summer | Sungold Minnow | Common | 25g |
| Summer | Lilyleap Frogfish | Common | 25g |
| Summer | Sunscale Bass | Uncommon | 70g |
| Summer | Reeftail Snapper | Uncommon | 75g |
| Summer | Driftwood Catfish | Uncommon | 70g |
| Summer | Dragonfly Darter | Rare | 130g |
| Fall | Coppergill Carp | Common | 25g |
| Fall | Harvestgill Bass | Common | 25g |
| Fall | Ambertail Trout | Uncommon | 65g |
| Fall | Rustfin Perch | Uncommon | 60g |
| Fall | Duskwater Pike | Uncommon | 70g |
| Fall | Mistfin Eel | Rare | 150g |
| Winter | Glacierscale Smelt | Common | 20g |
| Winter | Icevein Herring | Common | 20g |
| Winter | Silverfrost Cod | Uncommon | 65g |
| Winter | Frostgill Pike | Rare | 160g |
| Winter | Deepchill Sturgeon | Rare | 165g |
| Winter | Moonshadow Koi | Epic | 280g |

**Event Fish — Locked, new subcategory.** 2 per season, region-scattered, appearing only during a specific
festival or weather window (a Conditional Event, 03-npc-relationships.md 4.5 — world-state gated, not tied to any
relationship tier). Not purchasable, not in the regular catch pool the rest of the year — a genuine "you had to be
there" reward.

| Season | Event Fish | Rarity | Sell Price | Trigger |
|---|---|---|---|---|
| Spring | Blossomtail Koi | Rare | 140g | Cherry Blossom Festival week, at the Bay |
| Spring | Puddlejump Toadfish | Uncommon | 60g | Any Spring rainy day, in flooded Town Square puddles |
| Summer | Starlight Marlin | Epic | 300g | Summer nighttime festival, at the Dock |
| Summer | Emberfin Piranha | Rare | 135g | A heatwave weather event, in the Hidden Forest's hot spring |
| Fall | Harvest Moon Salmon | Epic | 290g | Fall Harvest Festival, at the River |
| Fall | Withered Eel | Rare | 145g | Unlocked by a specific World Story lore beat, then found in the Hidden Forest's murky ponds |
| Winter | Yulewater Salmon | Epic | 295g | Winter Solstice festival, at the Lake |
| Winter | Snowbound Anglerfish | Legendary | 520g | A Blizzard weather event, at night, in deep dungeon-adjacent waters |

The Rose-lore Legendary fish flagged below stays a separate, still-open idea — Snowbound Anglerfish fills the
"a Legendary fish should exist" gap without preempting that more story-specific one.

Open idea, not locked: a single Legendary-rarity fish tied specifically to World Story/Rose lore rather than a
generic "big rare fish" — worth revisiting once more of that track exists, rather than naming it now.

### Bugs — Expanded
Likely uses: Wild/Beast feed/crafting reagents (Beau's shop), collection/gift items, possibly Arcane reagents
(Leonair's shop). Expanded to **7 regular entries per season** — one more than Fish, since a farming sim's bug
population realistically outnumbers its fish variety.

| Season | Bugs | Rarity | Sell Price |
|---|---|---|---|
| Spring | Petal Moth | Common | 20g |
| Spring | Dewdrop Beetle | Common | 30g |
| Spring | Ladybug Sprite | Common | 20g |
| Spring | Garden Ant | Common | 15g |
| Spring | Snaildrift Beetle | Common | 25g |
| Spring | Blossom Weevil | Uncommon | 55g |
| Spring | Pixiewing Dragonfly | Uncommon | 55g |
| Summer | Emberwing Firefly | Uncommon | 55g |
| Summer | Velvet Longhorn Beetle | Uncommon | 65g |
| Summer | Sunbeetle | Common | 20g |
| Summer | Grasshopper Nymph | Common | 25g |
| Summer | Buzzwing Hornet | Uncommon | 60g |
| Summer | Jeweled Scarab | Rare | 130g |
| Summer | Sunspark Cicada | Rare | 125g |
| Fall | Amber Cicada | Rare | 120g |
| Fall | Rustwing Grasshopper | Common | 35g |
| Fall | Acorn Weevil | Common | 20g |
| Fall | Harvest Ant | Common | 15g |
| Fall | Rustling Leaf Bug | Common | 25g |
| Fall | Coppertail Beetle | Uncommon | 60g |
| Fall | Thistledown Moth | Uncommon | 60g |
| Winter | Frost Cricket | Uncommon | 60g |
| Winter | Glasswing Moth | Epic | 250g |
| Winter | Icevein Spider | Rare | 155g |
| Winter | Frostback Beetle | Common | 20g |
| Winter | Snowflake Moth | Uncommon | 55g |
| Winter | Icicle Weevil | Common | 25g |
| Winter | Pale Widow Spider | Rare | 150g |

**Event Bugs — Locked, new subcategory.** 1 per season, sharing the same trigger window as that season's showcase
Event Fish (same festival, same rough timing) — a reason to be in the right region at the right moment for both
catches at once.

| Season | Event Bug | Rarity | Sell Price | Trigger |
|---|---|---|---|---|
| Spring | Golden Bloom Butterfly | Epic | 260g | Cherry Blossom Festival week, at the Bay (same window as Blossomtail Koi) |
| Summer | Starlit Luna Moth | Epic | 270g | Summer nighttime festival, at the Dock (same window as Starlight Marlin) |
| Fall | Harvest Moon Mantis | Epic | 275g | Fall Harvest Festival, at the River (same window as Harvest Moon Salmon) |
| Winter | Yule Glow Beetle | Epic | 280g | Winter Solstice festival, at the Lake (same window as Yulewater Salmon) |

## 14.6 Trees and Orchards
Perennial placeables, distinct from the tilled seasonal-crop-rotation system — once planted and grown, they don't
need replanting each season.

**Sell prices — Locked.** Priced in the same Common range as farmed crops (perennial convenience offsets the longer
setup time) except Maple Syrup, a processed good priced above raw harvest.

| Category | Tree | Sell Price |
|---|---|---|
| Fruit | Rosehip Tree | 25g |
| Fruit | Fig Tree | 25g |
| Fruit | Plum Tree | 25g |
| Fruit | Apple Tree | 20g |
| Fruit | Pear Tree | 20g |
| Nut | Walnut Tree | 20g |
| Nut | Chestnut Tree | 15g |
| Nut | Oak Tree (acorns — feed/decor use) | 10g |
| Maple | Maple Tree (raw tap) | 15g |
| Maple | Maple Syrup (processed) | 35g |

**Rosehip Tree** is a deliberate thematic tie-in — rosehips are the literal fruit of a rose bush, connecting straight
back to the game's central imagery without being on-the-nose about it.

### Yearly Growth — Locked
Trees and Orchards get their own version of 14.2's growth mechanic: **1 new tree plus 1 new bush per year**, for
Years 1-4 (extended from Years 1-3 to match the crop rotation's extension in 14.2), then stopping.

| Year | Tree | Sell Price | Bush | Sell Price |
|---|---|---|---|---|
| 1 | Cherry Tree | 25g | Blackberry Bush | 25g |
| 2 | Peach Tree | 25g | Raspberry Bush | 25g |
| 3 | Persimmon Tree | 30g | Gooseberry Bush | 25g |
| 4 | Quince Tree | 25g | Juniper Bush | 25g |

Bushes are a new sub-category introduced here — smaller than trees, likely faster to mature, but still perennial
rather than tilled/replanted. Blackberry ties naturally into the game's existing thorn imagery.

## 14.7 Cross-Breeding / Hybrids — Locked
Ties to the Hybrid Seed Splicer (Earth tree, Tier 5 — see 3.7). Planting two crops **from the same season** adjacent
to each other gives a chance to produce a Hybrid variant combining traits of both (visual + a blended use-case —
decorative and edible, or two different gift/sell categories at once). Example: Strawberry x Tulip → a rare
decorative-edible hybrid.

**Cross-season hybridizing is not possible** — this is a hard rule, not just a description of the common case. A
Spring crop can never hybridize with a Fall crop, for instance, even hypothetically (e.g. via Greenhouse
year-round growing). Keeps the hybrid pool legible per-season rather than combinatorially exploding across all 20+
crops once the yearly growth additions are in.

**Curated pairs, not every combination — Locked.** Rather than every same-season pair producing a hybrid (which
would combinatorially explode with the starting roster alone), only a curated list of pairs actually can. Planting
two same-season crops adjacent that aren't on this list is a valid strategy for other reasons (space efficiency,
proximity buffs from other systems) but simply won't ever hybridize. This keeps the sprite/art workload (below)
bounded and lets each hybrid feel like a deliberate discovery rather than a background statistic.

**Drop-chance math — Locked:** a curated pair, both plants fully grown and adjacent, has a **base 10% chance per
in-game day tick** to produce a hybrid instead of a normal harvest. The Hybrid Seed Splicer's tree investment
(Earth/Growth Tier 5, 3.7) adds **+4% per skill point spent beyond the unlock point**, capping at **30%** — so a
fully-invested player roughly triples their odds over a fresh Tier 5 unlock, without ever hitting a guaranteed
hybrid.

**Hybrid sell price — Locked:** average of the two parent crops' sell prices, x1.5 (a rarity premium for the
harder-to-produce result), rounded to the nearest 5g.

### Curated Hybrid Pairs (starting roster)

| Season | Parent A | Parent B | Hybrid | Sell Price |
|---|---|---|---|---|
| Spring | Strawberries | Tulips | Strawberry Tulip | 35g |
| Spring | Peas | Carrots | Pea-Carrot Twist | 25g |
| Spring | Rhubarb | Forget-Me-Nots | Forget-Me-Not Rhubarb | 30g |
| Summer | Tomatoes | Sunflowers | Sunburst Tomato | 35g |
| Summer | Blueberries | Lavender | Lavender Blueberry | 40g |
| Summer | Melon | Corn | Honeyhusk Melon | 35g |
| Fall | Pumpkins | Chrysanthemums | Chrysanthemum Pumpkin | 40g |
| Fall | Cranberries | Amaranth | Amaranth Cranberry | 35g |
| Fall | Yams | Cranberries | Candied Yam Berry | 35g |
| Winter | Winter Roots | Holly | Hollyroot | 35g |
| Winter | Winter Roots | Snow Peas | Frostroot Pea | 30g |
| Winter | Holly | Snow Peas | Snow-Holly Sprig | 35g |

Every entry doubles as a decorative-edible or a cross-category sell item (Strawberry Tulip works as both a
Placeables/Decor item and produce, per the pattern already set by the starting example), matching the "blended
use-case" design intent from the rule above. Winter gets all 3 possible pairings from its sparse 3-crop roster,
since there's no larger pool to curate down from.

Yearly-addition crops (14.2) aren't included in this pass — a second curation round once those are more settled is
flagged as future work, not urgent since Winter (the only season without new additions) already has full coverage.

**Sprite/art note:** every hybrid result needs its own custom sprite once art direction begins — flagging this now
so it's on the list for that pass, since hybrids can't just reuse either parent crop's sprite.

## 14.8 Open Questions
- Exact bush mechanics (maturation time, placement rules) — introduced in 14.6 but not detailed yet.
- Hybrid pairing curation for the 12 yearly-addition crops (14.2) and the expanded 14.3 starting roster's new
  entries — the original starting roster's pairs are locked (14.7), the rest are not yet folded in.

**Resolved:**
- Sell prices for all farmed crops, wild-foraged plants, and trees/orchards (including yearly additions) — see the
  tables in 14.3, 14.4, and 14.6.
- Hybrid pairing table and drop-chance math for the starting roster — see 14.7.
- Crop/forage density expansion — Spring/Summer/Fall at 9 farmed crops each (Winter at 6), 6 wild-foraged plants
  per season, yearly crop rotation extended through Year 4 (12 total additions), tree/bush growth extended through
  Year 4.
