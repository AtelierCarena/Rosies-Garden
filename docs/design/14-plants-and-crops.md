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
weren't available before. This continues through Year 3, then stops: by Year 4 the crop roster is permanently
complete (the 14.3 starting list, plus these 9 crops added across Years 1-3).

Each year's 3 additions land in Spring, Summer, and Fall only — Winter stays untouched across all three years,
reinforcing its intentional scarcity (14.3) and the incentive to invest in the Greenhouse rather than diluting that
design goal with new Winter content.

| Year | Spring | Summer | Fall |
|---|---|---|---|
| 1 | Larkspur | Zinnias | Elderberries |
| 2 | Anemones | Basil | Belladonna |
| 3 | Foxglove | Mint | Wheat |

A few notes on these picks:
- **Belladonna** continues the "beautiful but dangerous" thread already running through Nightshade Berries (14.4)
  — another strong Alchemy reagent candidate for Mina's shop (8.2).
- **Basil** and **Mint** are the first cooking-herb crops in the roster — plausible ingredients for Delphine (Chef,
  12-npc-roster.md).
- **Wheat** is the roster's first grain/staple crop — useful for baking, and was a genuine gap before this.

A plausible future hook, still not locked: Percival could be the one who first mentions a new crop exists, before it's
purchasable — same "informationally known before physically available" pattern already established for Wild Spawns
in 9.3.

## 14.3 Farmed Crops (starting roster, first-pass)
Leans into the game's soft/floral aesthetic rather than generic fantasy produce — several entries double as
Placeables/Decor material once harvested (8.4) or as gift items for the NPC gift-preference system (4.3).

| Season | Crops |
|---|---|
| Spring | Strawberries, Peas, Tulips, Rhubarb, Carrots, Forget-Me-Nots |
| Summer | Tomatoes, Sunflowers, Blueberries, Melon, Lavender, Corn |
| Fall | Pumpkins, Cranberries, Amaranth, Yams, Chrysanthemums |
| Winter | Winter Roots, Holly, Snow Peas — deliberately sparse; Winter is meant to be the lean season, encouraging Greenhouse investment |

**Forget-Me-Nots** are a deliberate echo of the dungeon bracket name (Forget-Me-Not Fields, 10-dungeons-and-risk.md)
— the same flower exists literally in the farmable world, not just as dungeon flavor text.

## 14.4 Wild-Foraged Plants — Revised
Original items, not reused/reskinned from Stardew Valley's forage list (the first draft leaned too hard on that —
Spring Onions was literally the same item). Leans into the coquette-gothic-garden aesthetic instead: real,
evocative flower/plant names that lean a little dark or a little strange, rather than generic real-world forage.
Tied to the Wild Spawn seasonal resource zones from 9.3, with the physically-discovered / informationally-known
flag split applying to each.

| Season | Wild Plants |
|---|---|
| Spring | Bleeding Heart Blossom, Dew-Kissed Clover, Sweetpea Vine |
| Summer | Honeysuckle, Nightshade Berries, Firefly Nectar |
| Fall | Witch Hazel Bark, Amber Resin, Thistledown |
| Winter | Frost-Kissed Ivy, Silverbell Sprigs, Snowdrop Blossom |

Nightshade Berries and Witch Hazel Bark are plausible Alchemy reagents (ties to Mina's shop, 8.2's Alchemy
system) rather than pure gift/decor items.

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

### Fish
Ties to Silas's Fisherman role and the fishing Shared Activity (4.3). Freshwater-flavored given Silas is
docks/riverside-based.

| Season | Fish | Rarity | Sell Price |
|---|---|---|---|
| Spring | Glassfin Minnow | Common | 25g |
| Spring | Blushcarp | Uncommon | 60g |
| Summer | Sunscale Bass | Uncommon | 70g |
| Summer | Dragonfly Darter | Rare | 130g |
| Fall | Ambertail Trout | Uncommon | 65g |
| Fall | Mistfin Eel | Rare | 150g |
| Winter | Frostgill Pike | Rare | 160g |
| Winter | Moonshadow Koi | Epic | 280g |

Open idea, not locked: a single Legendary-rarity fish (500g+, per the table above) tied to World Story/Rose lore
rather than a generic "big rare fish" — worth revisiting once more of that track exists, rather than naming it now.

### Bugs
Likely uses: Wild/Beast feed/crafting reagents (Beau's shop), collection/gift items, possibly Arcane reagents
(Leonair's shop).

| Season | Bugs | Rarity | Sell Price |
|---|---|---|---|
| Spring | Petal Moth | Common | 20g |
| Spring | Dewdrop Beetle | Common | 30g |
| Summer | Emberwing Firefly | Uncommon | 55g |
| Summer | Velvet Longhorn Beetle | Uncommon | 65g |
| Fall | Amber Cicada | Rare | 120g |
| Fall | Rustwing Grasshopper | Common | 35g |
| Winter | Frost Cricket | Uncommon | 60g |
| Winter | Glasswing Moth | Epic | 250g |

## 14.6 Trees and Orchards
Perennial placeables, distinct from the tilled seasonal-crop-rotation system — once planted and grown, they don't
need replanting each season.

| Category | Trees |
|---|---|
| Fruit | Rosehip Tree, Fig Tree, Plum Tree, Apple Tree, Pear Tree |
| Nut | Walnut Tree, Chestnut Tree, Oak Tree (acorns — feed/decor use) |
| Maple | Maple Tree — tappable for syrup (a Fall/Winter activity), and a wood-type resource variant for the Forge/Craft tree |

**Rosehip Tree** is a deliberate thematic tie-in — rosehips are the literal fruit of a rose bush, connecting straight
back to the game's central imagery without being on-the-nose about it.

### Yearly Growth — Locked
Trees and Orchards get their own version of 14.2's growth mechanic: **1 new tree plus 1 new bush per year**, for
Years 1-3, then stopping — same three-year settling pattern as the tilled crop rotation, for consistency across
both systems.

| Year | Tree | Bush |
|---|---|---|
| 1 | Cherry Tree | Blackberry Bush |
| 2 | Peach Tree | Raspberry Bush |
| 3 | Persimmon Tree | Gooseberry Bush |

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

**Sprite/art note:** every hybrid result needs its own custom sprite once art direction begins — flagging this now
so it's on the list for that pass, since hybrids can't just reuse either parent crop's sprite.

## 14.8 Open Questions
- Full hybrid pairing table (which specific same-season pairs produce which hybrid) and drop-chance math.
- Full crop list expansion beyond the starting roster + the now-locked 9 yearly additions.
- Exact bush mechanics (maturation time, placement rules) — introduced in 14.6 but not detailed yet.
