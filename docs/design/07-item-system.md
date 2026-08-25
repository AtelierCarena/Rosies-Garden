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

**Chef's Range — Locked, new structure:** the player asks Delphine how to unlock more recipes/better cooking
tiers; she directs them to August, whose Upgrades tab (locked until this conversation happens) is where the Chef's
Range is actually commissioned and built (02-skill-trees.md, 3.8). Delphine opens the door, August does the labor —
the one structure in the game that can't be self-built via Forge/Craft alone, and one of the more expensive
Upgrades-tab entries. Gates the Rare-and-up recipes below behind both a dialogue trigger and a real gold
investment, distinguishing them from Tier 1's Uncommon-tier fare.

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
| Snapdragon Nibbles | 2x Snapdragons | 50g | Small Heart restore (pure-heal), decorative-edible dual sell | 75g |
| Glazed Radish | 1x Radishes | 15g | Small Heart restore (pure-heal) | 25g |
| Beet Chips | 2x Beets | 40g | Small Heart restore (pure-heal) | 60g |

### Tier 1 — Simple Cooking Pot Recipes

| Meal | Recipe | Ingredient Cost | Effect | Sell Price |
|---|---|---|---|---|
| Garden Stew | 1x Carrots + 1x Tomatoes + 1x Peas | 50g | Medium Heart restore (pure-heal) | 90g |
| Pumpkin Harvest Soup | 2x Pumpkins + 1x Yams | 80g | Medium Heart restore + cold-resist buff (Fall/Winter flavor) | 130g |
| Lavender Iced Tea | 2x Lavender + 1x Melon | 80g | Small Heart restore + temporary Charm/Trade buff (Dahlia synergy) | 130g |
| Basil Cranberry Tart | 1x Basil + 2x Cranberries | 70g | Medium Heart restore (pure-heal) | 120g |
| Acorn Squash Bake | 2x Acorn Squash + 1x Yams | 70g | Medium Heart restore (pure-heal) | 125g |
| Winter Cabbage Roll | 2x Winter Cabbage + 1x Parsnips | 55g | Medium Heart restore + cold-resist buff (Winter's second buff-meal alongside Pumpkin Harvest Soup) | 100g |
| Pixie Cap Risotto | 2x Pixie Cap Mushroom + 1x Basil | 140g | Medium Heart restore + minor Arcane/mana buff (Leonair synergy) | 250g |

### Tier 2+ — Chef's Range Recipes (Rare and up)

| Meal | Recipe | Ingredient Cost | Effect | Sell Price |
|---|---|---|---|---|
| Chef's Catch Platter | 2x any Uncommon-tier Fish + 1x Mint | ~150g | Large Heart restore + Stamina buff | 240g (Epic) |
| Nightshade Reduction | 2x Nightshade Berries + 1x Witch Hazel Bark | ~255g | Large Heart restore + temporary Attack buff, but a small chance (~15%) to inflict brief Poison status if eaten outside deliberate prep — a genuine risk/reward dish, not just flavor text, continuing the "beautiful but dangerous" thread from Nightshade Berries and Witch Hazel Bark (14.4) | 400g (Legendary) |
| Blackthorn Bramble Tart | 2x Blackthorn Berries + 1x Amber Resin | ~220g | Large Heart restore + Attack buff — another "dangerous beauty" dish, without the poison-chance twist Nightshade Reduction carries | 350g (Epic) |
| Widow's Lace Consommé | 2x Widow's Lace + 1x Hoarfrost Lichen | ~205g | Large Heart restore + cold-immunity — Winter's first Chef's Range dish, filling a gap the original recipe set left open | 320g (Epic) |

Nightshade Reduction is meant to read as a tactical pre-boss-fight dish rather than a casual snack — the poison
chance rewards deliberate use (eating it in a safe moment before a fight) over reflexive spamming.

## 8.6 Alchemy / Potions — Locked
Fills a gap that had sat open since 8.2 first mentioned Alchemy as a temporary-buff system distinct from
Enchanting — no actual potions existed until now. Sold via Mina's Apothecary (12-npc-roster.md), crafted from the
Alchemy-reagent-flavored wild-foraged plants locked in 14-plants-and-crops.md, 14.4.

**Two tiers — Locked:**
- **Base Potions (8):** available from the start at Mina's shop, once the player has the relevant reagents. Flat
  Uncommon-tier price (70g), matching the wild-forage cost band they're crafted from.
- **Advanced/Unlockable Potions (8):** each locked behind a distinct unlock path rather than simple gold purchase —
  quest completion, an NPC friendship milestone, skill-tree advancement, a World Story/lore revelation, a
  shop-exclusive purchase, or a scroll found in the dungeon. Rare-to-Legendary tier, reflecting the extra investment
  each one demands.

### Base Potions

| Potion | Recipe | Effect | Price |
|---|---|---|---|
| Sunscale Tonic | Sunburst Fern + Wild Chamomile | Minor Stamina regen | 70g |
| Frostward Elixir | Hoarfrost Lichen + Frost-Kissed Ivy | Cold/damage resist | 70g |
| Bloomwake Serum | Moonpetal Iris + Dew-Kissed Clover | Minor heal-over-time | 70g |
| Emberheart Tonic | Amber Resin + Blackthorn Berries | Damage buff | 70g |
| Clarity Draught | Wild Chamomile + Sweetpea Vine | Cures status debuffs | 70g |
| Widow's Veil Potion | Widow's Lace + Silverbell Sprigs | Evasion/stealth buff | 70g |
| Honeyglow Balm | Bee Balm + Firefly Nectar | Charm/Trade buff | 70g |
| Nightshade Draught | Nightshade Berries + Witch Hazel Bark | Attack buff, poison-risk — Alchemy's own version of the Nightshade Reduction dish (8.5), sold raw rather than cooked | 70g |

### Advanced / Unlockable Potions

| Potion | Unlock Path | Effect | Price |
|---|---|---|---|
| Verdant Bloom Elixir | Quest reward — Ophelia's personal questline | Large heal + minor temporary Earth/Growth yield buff | 150g (Rare) |
| Silvertongue Draught | Friendship milestone — Confidant tier with Dahlia | Strong Charm/Trade buff, above Honeyglow Balm's tier | 150g (Rare) |
| Archivist's Insight | Skill-tree advancement — Arcane Tier 5 (3.7) | Temporarily reveals hidden dungeon rooms/traps — a consumable version of Percival's Escort ability (12-npc-roster.md, 13.3) | 180g (Rare) |
| Rosebound Tonic | Lore revelation — a World Story beat tied to Rose's discovery chain (05-character-cast.md, 6.4) | Large heal + brief damage resist, thematically tied to Rose's imagery | 500g (Legendary) |
| Thornsteel Draught | Shop-exclusive — purchase only, no recipe, sold solely at Gideon's Forge | Temporary Armor/Defense buff, themed to Thornsteel ore (16.2) | 200g (Epic) |
| Moonshadow Brew | Dungeon scroll — found in the Porcelain Orchards or Her Hollow bracket (10-dungeons-and-risk.md), teaches the recipe on pickup (Event/Relationship-Unlocked channel, 3.6) | Temporary stealth/evasion buff + minor increase to Legendary-loot chance (11.2) | 250g (Epic) |
| Gatekeeper's Resolve | Friendship milestone — Confidant tier with Thorne | Temporary max-Heart increase for one dungeon run | 160g (Rare) |
| Hollowroot Cure-All | Quest reward — Sebastian's or Daisy's personal questline | Cures all debuffs + moderate heal — a "master medicine" capstone potion | 280g (Epic) |

Every unlock category the collaborative brainstorm asked for is represented at least once (quest x2, friendship
milestone x2, skill-tree advancement x1, lore revelation x1, shop-exclusive x1, dungeon scroll x1) — a template for
adding more Advanced Potions later without needing to invent new unlock mechanisms first.
