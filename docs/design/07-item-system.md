# 8. Item System

## 8.1 Rarity Tiers
Common -> Uncommon -> Rare -> Epic -> Legendary. Affects drop rates, visual flair (scaling glow/particle effects), sell
value, and — for gear specifically — enchantment slot count.

## 8.2 Gear: Fixed Stats, Not RNG Rolls
- Base stats are fixed per recipe/tier — e.g. every Tier 3 Forge sword has identical base stats. No randomized
  ARPG-style stat rolls.
- **Enchantments** (Arcane-sourced): PERMANENT once applied by default. Slot count scales with item rarity, so higher
  rarity means more build depth, not just bigger numbers:

  | Rarity | Enchant Slots |
  |---|---|
  | Common | 0 |
  | Uncommon | 1 |
  | Rare | 2 |
  | Epic | 3 |
  | Legendary | 4 |

  Enchantments can be removed via **Disenchanting** at a high-tier Arcane structure (the Arcane Altar line, ~Tier 7-8 —
  the same structure that unlocks portals and familiars). Disenchanting destroys the existing enchantment with no
  material refund and clears the slot for a new one — a real cost, not a free respec, so applying an enchantment stays
  a meaningful decision. This mirrors the "permanent unless you pay a steep, deliberate price" pattern used for
  capstones and skill respec (see 02-skill-trees.md, 3.4).
- **Alchemy** (Earth/Arcane crossover): TEMPORARY buffs requiring reapplication — oils, coatings, potions. Gives
  Alchemy a distinct identity from Enchanting (build identity vs. situational prep) and keeps Earth-tree farming relevant
  even in combat-heavy play.
- **Durability:** Tools and Weapons/Armor have durability; Placeables/Decor do not (8.4 — decorations just get
  relocated, never damaged or consumed). Durability scales with the **Ore tier** used to craft the item (see
  16-resources-and-materials.md, 16.2 — higher tier ore means higher base durability), further modified by any
  Enchantments applied. If an item has both a wood and an ore component (e.g. an axe handle + head), only the ore
  portion affects durability — wood is purely cosmetic (16.1) and never a stat input.
- **Enchantment scaling — Locked:** each filled Enchant slot adds **+10% durability** on top of the item's ore-tier
  base (16.2), and **+10% sell/base price** the same way — durability and value scale together rather than as
  separate systems, so a fully-enchanted item reads as more durable *and* more valuable at a glance. A Legendary
  Thornsteel item with all 4 slots filled sits around 500 x 1.4 = 700 durability, at 1.4x its unenchanted price.

## 8.3 Cosmetics: Fully Separate From Stat Gear
Appearance/Outfit is an independent slot system from functional Armor — a player can wear a Legendary chestplate for
stats while visually appearing in a cute sundress. Cosmetics become a strong reward category for non-combat content
(relationship milestones, shop purchases, event-exclusives, achievements) since they never need power-balancing.

## 8.4 Item Category Reference

| Category | Has Rarity? | Primary Source(s) |
|---|---|---|
| Resources/Materials | Yes | Gathering, some crafted |
| Crafted Goods | Sometimes (higher tiers) | Crafting |
| Tools | Yes (tier-linked) | Crafting |
| Weapons/Armor | Yes | Crafting (base) + Enchant/Alchemy (upgrade) |
| Consumables | Yes (potency scales) | Crafting, gathering, purchase |
| Seeds/Crops | Yes (mutation-linked) | Farming, cross-breeding |
| Placeables/Decor | Yes (prestige) | Crafting, purchase, events |
| Companion Items | Yes | Crafting, purchase, quest |
| Cosmetics/Outfits | Yes (prestige, not power) | Shops, relationships, events, achievements |
| Quest/Key Items | No | Story/discovery only |
| Currency/Trade Goods | N/A | Selling, quests |
