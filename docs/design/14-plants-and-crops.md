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
complete (the starting list below, plus 9 crops added across Years 1-3).

Which season each year's 3 new crops land in, and what those crops actually are, is left open for a later pass —
this locks the *mechanic* (a living, year-over-year-growing world that eventually settles), not the specific
additions yet. A plausible future hook: Sage could be the one who first mentions a new crop exists, before it's
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

Nightshade Berries and Witch Hazel Bark are plausible Alchemy reagents (ties to Thistle's shop, 8.2's Alchemy
system) rather than pure gift/decor items.

## 14.5 Fish and Bugs (new)
**Design directive:** same correction as 14.4 — stylized, thematic names, not real-world species pulled 1:1 the way
Stardew does. First pass only; full rarity/sell-price/catch-mechanic design comes later.

### Fish
Ties to Alder's Fisherman role and the fishing Shared Activity (4.3). Freshwater-flavored given Alder is
docks/riverside-based.

| Season | Fish |
|---|---|
| Spring | Glassfin Minnow, Blushcarp |
| Summer | Sunscale Bass, Dragonfly Darter |
| Fall | Ambertail Trout, Mistfin Eel |
| Winter | Frostgill Pike, Moonshadow Koi |

Open idea, not locked: a single Legendary-rarity fish (per 8.1) tied to World Story/Rose lore rather than a
generic "big rare fish" — worth revisiting once more of that track exists.

### Bugs
Likely uses: Wild/Beast feed/crafting reagents (Beau's shop), collection/gift items, possibly Arcane reagents
(Ember's shop).

| Season | Bugs |
|---|---|
| Spring | Petal Moth, Dewdrop Beetle |
| Summer | Emberwing Firefly, Velvet Longhorn Beetle |
| Fall | Amber Cicada, Rustwing Grasshopper |
| Winter | Frost Cricket, Glasswing Moth |

## 14.6 Trees and Orchards (new)
Perennial placeables, distinct from the tilled seasonal-crop-rotation system — once planted and grown, they don't
need replanting each season. Not currently subject to the Yearly Crop Rotation Growth mechanic (14.2); that's
scoped to tilled crops for now, but could extend here later if wanted.

| Category | Trees |
|---|---|
| Fruit | Rosehip Tree, Fig Tree, Plum Tree, Apple Tree, Pear Tree |
| Nut | Walnut Tree, Chestnut Tree, Oak Tree (acorns — feed/decor use) |
| Maple | Maple Tree — tappable for syrup (a Fall/Winter activity), and a wood-type resource variant for the Forge/Craft tree |

**Rosehip Tree** is a deliberate thematic tie-in — rosehips are the literal fruit of a rose bush, connecting straight
back to the game's central imagery without being on-the-nose about it.

## 14.7 Cross-Breeding / Hybrids — Locked
Ties to the Hybrid Seed Splicer (Earth tree, Tier 5 — see 3.7). Planting two same-season crops adjacent to each
other gives a chance to produce a Hybrid variant combining traits of both (visual + a blended use-case — decorative
and edible, or two different gift/sell categories at once). Example: Strawberry x Tulip → a rare decorative-edible
hybrid.

**Sprite/art note:** every hybrid result needs its own custom sprite once art direction begins — flagging this now
so it's on the list for that pass, since hybrids can't just reuse either parent crop's sprite.

## 14.8 Open Questions
- Which specific crops land in which season for the 3-new-crops-per-year growth (14.2).
- Full hybrid pairing table and drop-chance math.
- Fish/bug rarity tiers, catch mechanics, and sell prices.
- Full crop list expansion beyond this first-pass starting roster.
- Whether Trees and Orchards should also get yearly additions like tilled crops.
