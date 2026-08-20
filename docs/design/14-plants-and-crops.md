# 14. Plants and Crops

**Status: first-pass proposal, not locked.** Builds on 9.3 (Map System) and 3.7 (Earth/Growth tree), both of which
already assume a season calendar without ever formalizing one.

## 14.1 Season Calendar (proposed)
Four seasons — Spring, Summer, Fall, Winter — 28 days each, Stardew-standard. Crops are season-locked by default; a
crop planted outside its season withers. The Greenhouse (Earth tree, Tier 7 — see 3.7) is the existing mechanism
that lifts this restriction, matching its established "unlocks year-round growing" description.

Crops are **not skill-tree gated** — Earth/Growth nodes affect yield, mutation, and terraforming (per 3.7), not
which seeds are purchasable. Availability is governed by season and rarity instead.

## 14.2 Farmed Crops
Aiming for a modest starting list per season (6-8), expandable later. Leans into the game's soft/floral aesthetic
rather than generic fantasy produce — several entries double as Placeables/Decor material once harvested (ties to
8.4) or as gift items for the NPC roster's gift-preference system (4.3).

| Season | Crops |
|---|---|
| Spring | Strawberries, Peas, Tulips, Rhubarb, Carrots, Forget-Me-Nots |
| Summer | Tomatoes, Sunflowers, Blueberries, Melon, Lavender, Corn |
| Fall | Pumpkins, Cranberries, Amaranth, Yams, Chrysanthemums |
| Winter | Winter Roots, Holly, Snow Peas — deliberately sparse; Winter is meant to be the lean season, same as Stardew, encouraging Greenhouse investment |

**Forget-Me-Nots** are a deliberate echo of the dungeon bracket name (Forget-Me-Not Fields, 10-dungeons-and-risk.md)
— the same flower exists literally in the farmable world, not just as dungeon flavor text.

## 14.3 Wild-Foraged Plants
Tied to the Wild Spawn seasonal resource zones already described in 9.3 (the "spring onion patch" example is
literally this system) — found rather than planted, with the physically-discovered / informationally-known flag
split from 9.3 applying to each.

| Season | Wild Plants |
|---|---|
| Spring | Spring Onions, Wild Violets |
| Summer | Wild Berries, Sweetgrass |
| Fall | Wild Mushrooms, Hazelnuts |
| Winter | Frostberries, Pine Sprigs |

## 14.4 Cross-Breeding / Hybrids
Ties to the Hybrid Seed Splicer (Earth tree, Tier 5 — see 3.7). Planting two same-season crops adjacent to each
other gives a chance to produce a Hybrid variant combining traits of both (visual + a blended use-case — decorative
and edible, or two different gift/sell categories at once). Example: Strawberry x Tulip → a rare decorative-edible
hybrid. Exact pairing list and drop-chance math intentionally left open for a later balancing pass — the mechanic is
what's being proposed here, not the full combinatorial table.

## 14.5 Open Questions
- Does the 28-day/4-season calendar hold, or should it scale differently given other systems (dungeon depth, skill
  point trickle) already in place?
- Full crop list expansion once this first pass is confirmed.
- Full hybrid pairing table.
- Sell prices / Trade tree interaction specifics.
