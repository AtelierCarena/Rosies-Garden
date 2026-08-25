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

## 8.5 Cooking / Food Consumables — Locked
Ties to the Campfire and Simple Cooking Pot (08-starting-experience.md, 9.2), Delphine's Chef role (12-npc-roster.md),
and the crop/wild-plant/fish sell prices locked in 14-plants-and-crops.md. Three station tiers gate meal
tiers, mirroring the tool-tier gating pattern already used for Ore/Pickaxes (16.2).

**Pricing logic:** meal sell price is roughly ingredient cost x a markup that scales with station tier — reflecting
skill/prep value added, not just raw materials passed through.

| Station Tier | Markup | Unlocks |
|---|---|---|
| Tier 0 — Campfire | ~1.5x ingredient cost | Simple, 1-ingredient meals, no station upgrade needed |
| Tier 1 — Simple Cooking Pot | ~1.8x ingredient cost | Multi-ingredient meals |
| Tier 2+ — Chef's Range (new, gated) | ~2.5x ingredient cost | Rare/Epic/Legendary-tier showcase meals |

**Auto-scaling — Locked:** cooking tier is tied directly to the physical Kitchen structure on the player's
Homestead, not a separate recipe-unlock step. Campfire, Simple Cooking Pot, and Chef's Range are the three
successive upgrade stages of the same Kitchen structure (per 02-skill-trees.md, 3.5's build-early/upgrade pattern) —
the moment the player upgrades to a given stage, every recipe at that tier and below becomes immediately craftable,
with no additional per-recipe unlock.

**Chef's Range — Locked, new structure:** built by commissioning August, the Carpenter/Architect
(12-npc-roster.md), plus reaching Delphine's relationship-tier gate for the recipe/design input — the one
structure in the game that can't be self-built via Forge/Craft alone (02-skill-trees.md, 3.8). Gates the Rare-and-up
recipes below behind both progression and relationship investment, distinguishing them from Tier 1's Uncommon-tier
fare.

**Buff meals vs. pure-heal meals — Locked:** Food splits into two flavors, decided per-recipe rather than a hard
rule:
- **Pure-Heal meals:** restore Hearts only. The simple/cheap end, mostly Tier 0.
- **Buff meals:** restore Hearts AND grant a temporary situational buff (Stamina, Charm/Trade, cold-resist, Attack,
  etc.) tied to the ingredients' flavor. The higher-tier/pricier end — gives cooking investment a reason to exist
  beyond just bigger heal numbers.

### Tier 0 — Campfire Recipes

| Meal | Recipe | Ingredient Cost | Effect | Sell Price |
|---|---|---|---|---|
| Roasted Corn | 1x Corn | 15g | Small Heart restore (pure-heal) | 25g |
| Baked Yam | 1x Yam | 20g | Small Heart restore (pure-heal) | 35g |
| Toasted Chestnuts | 2x Chestnut | 30g | Small Heart restore (pure-heal) | 50g |
| Pan-Seared Catch | 1x any Common-tier Fish | ~20-25g | Small Heart restore, minor Stamina buff | 40g |
| Berry Skewer | 1x any Berry crop | ~20-25g | Small Heart restore (pure-heal) | 40g |

### Tier 1 — Simple Cooking Pot Recipes

| Meal | Recipe | Ingredient Cost | Effect | Sell Price |
|---|---|---|---|---|
| Garden Stew | 1x Carrots + 1x Tomatoes + 1x Peas | 50g | Medium Heart restore (pure-heal) | 90g |
| Pumpkin Harvest Soup | 2x Pumpkins + 1x Yams | 80g | Medium Heart restore + cold-resist buff (Fall/Winter flavor) | 130g |
| Lavender Iced Tea | 2x Lavender + 1x Melon | 80g | Small Heart restore + temporary Charm/Trade buff (Dahlia synergy) | 130g |
| Basil Cranberry Tart | 1x Basil + 2x Cranberries | 70g | Medium Heart restore (pure-heal) | 120g |

### Tier 2+ — Chef's Range Recipes (Rare and up)

| Meal | Recipe | Ingredient Cost | Effect | Sell Price |
|---|---|---|---|---|
| Chef's Catch Platter | 2x any Uncommon-tier Fish + 1x Mint | ~150g | Large Heart restore + Stamina buff | 240g (Epic) |
| Nightshade Reduction | 2x Nightshade Berries + 1x Witch Hazel Bark | ~255g | Large Heart restore + temporary Attack buff, but a small chance (~15%) to inflict brief Poison status if eaten outside deliberate prep — a genuine risk/reward dish, not just flavor text, continuing the "beautiful but dangerous" thread from Nightshade Berries and Witch Hazel Bark (14.4) | 400g (Legendary) |

Nightshade Reduction is meant to read as a tactical pre-boss-fight dish rather than a casual snack — the poison
chance rewards deliberate use (eating it in a safe moment before a fight) over reflexive spamming.
