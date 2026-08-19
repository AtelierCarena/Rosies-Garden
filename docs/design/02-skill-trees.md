# 3. Skill Tree System

## 3.1 Philosophy: No Fixed Classes
There is no locked-in "Class" chosen at character creation. Instead, players invest points freely across 5 flexible skill
trees. Investment is deep, not cosmetic — each tree meaningfully shapes both cozy mechanics
(farming/building/crafting) and combat, so a farmer-mage or a warrior-blacksmith emerges from player choice rather
than a pre-baked hybrid class.

> Note: this is distinct from the 9 starting Combat Classes (Section 10), which govern starting weapon/loadout flavor
> only and do not restrict skill tree investment.

## 3.2 The Five Trees

| Tree | Domain |
|---|---|
| Earth / Growth | Farming yields, crop mutation, terraforming, nature magic (healing, thorn traps). |
| Forge / Craft | Building speed and unique structures, tool/weapon quality, armor-based tanky combat. |
| Arcane | Magic-crafting unlocks, spell damage/utility, magic-assisted resource gathering. |
| Wild / Beast | Companion bonding and strength, creature-based gathering (taming/ranching), ranged/agility combat. |
| Trade / Charm | Shop profit, NPC relationship gain speed, support/debuff-based combat (charm, price-based magic). |

## 3.3 Ten-Tier Structure (per tree)
Each tree follows the same six-phase rhythm across 10 tiers, giving consistent pacing while each tree's content stays
flavorfully distinct:

| Tiers | Phase | Purpose |
|---|---|---|
| 1-2 | Foundation | Cheap, immediate, teaches the tree's identity. |
| 3-4 | Fork | Mutually-exclusive playstyle choice (only on trees where a fork feels natural — some trees stay linear here instead). |
| 5-6 | Crossover | A new mechanic that touches another tree (e.g. a spell, an enchant, a charm effect). |
| 7-8 | Structural Gate | Requires a built structure PLUS spent points — not points alone. |
| 9 | Pre-Capstone | A powerful passive that sets up both capstone directions without committing. |
| 10 | Capstone | Two competing, mutually-exclusive options: one combat-leaning, one cozy-leaning. |

## 3.4 Points, Progression, and Respec
- **Earning points — hybrid model:** a small passive trickle from doing tree-relevant activities (farming feeds Earth,
  building feeds Forge, fighting feeds Wild/combat, etc.), plus larger milestone bursts from quests, story beats, boss
  kills, and relationship thresholds — tying narrative progress to power progress.
- **Progression is open** — every tree is eventually maxable, just slow. Kept meaningful via escalating point costs per
  tier (later nodes cost exponentially more) plus cross-tree structural prerequisites (e.g. certain Arcane nodes may
  require both Arcane points AND a built Forge structure).
- **Capstones stay permanent identity markers** even in a fully-maxed late game — since everything else is
  eventually reachable, which capstone a player picked per tree is what still defines their build.
- **Respec** is location/NPC-gated rather than free or unlimited. Exact mechanism TBD — candidates include a
  recurring wandering NPC (narrative hook) and/or a buildable "Respec Shrine" (ties into the building loop); possibly
  both, unlocked at different points. See Parking Lot.

## 3.5 Build-Early, Unlock-Later Structures
Structures can be built any time the player has the resources, regardless of skill tier — there is no hard lock on
construction itself. Interacting with a structure before its gating tier triggers a "confused" flavor response (an idle
animation, voice line, or text blurb showing the character doesn't yet understand what it does) rather than a flat
"locked" message. Reaching the gating tier "activates" the structure, ideally with its own small moment (a spark/glow, a
satisfied voice line, a one-time tooltip) so the unlock feels like an event. This pattern applies uniformly across all 5
trees, with unique flavor text per structure/tree.

## 3.6 Recipe and Machine Unlock Sources
Every craftable recipe or machine in the game unlocks through one of three channels:

| Source | How It Works |
|---|---|
| Tier-Unlocked | Tied directly to skill points spent — a steady drip of new recipes as a tree levels, Forager-style. |
| Structure-Gated | Requires the physical machine to be built in the world (DST-style) — separate from unlocking the *ability* to build it. |
| Event / Relationship-Unlocked | Taught by an NPC at a friendship milestone, or granted via a story cutscene/blueprint. Cannot be bought with skill points at all — only story or relationships unlock these, making relationships mechanically rewarding rather than pure flavor. |

## 3.7 Full Tree Drafts

### Earth / Growth
*Capstones: Verdant Avatar (combat) vs. Eternal Harvest (cozy)*

| Tier | Skill Node | Recipe / Machine Unlocked |
|---|---|---|
| 1 | +10% crop yield | Compost Bin (hand-craftable) |
| 2 | Small chance a crop isn't consumed on harvest; unlocks hand terraforming | Basic Fertilizer |
| 3 (Fork) | Bountiful (chance for double harvest) OR Quickgrow (reduced growth time) | Growth Charm / Speed Tonic |
| 4 | Chosen fork scales up | Machine: Greenhouse (buildable; fully functional at Tier 7) |
| 5 | Cross-breeding / crop mutation unlocked | Hybrid Seed Splicer |
| 6 (Crossover) | Spell: Bloom Pulse — AoE heal on farmland; crops resist weather damage | Weatherward Charm |
| 7 (Structural) | Requires Greenhouse — unlocks year-round growing | Greenhouse becomes functional |
| 8 (Structural) | Requires Sacred Grove — large-scale terraforming; thorn traps unlocked | Machine: Sacred Grove |
| 9 (Pre-Cap) | Passive: farmland grants a small regen aura to nearby allies | Aura Totem |
| 10 (Capstone) | Verdant Avatar (combat transformation) OR Eternal Harvest (self-sustaining farmland) | Avatar Seed / Everroot Sapling |

### Forge / Craft
*Capstones: Bulwark Form (combat) vs. Architect's Eye (cozy)*

| Tier | Skill Node | Recipe / Machine Unlocked |
|---|---|---|
| 1 | +10% build speed | Basic Repair Kit |
| 2 | Reduced resource cost on basic structures; unlocks repair tool | Blueprint Table |
| 3 (Fork) | Aesthetic (decorative structure variants) OR Functional (reinforced/upgraded stats) | Ornate Trim Kit / Reinforced Frame |
| 4 | Chosen fork scales up | Paint/Dye Station OR Structural Brace |
| 5 | Blueprint snapping / precision building | Precision Tools |
| 6 (Crossover) | Enchant weapons/armor with a chosen element (Arcane tie-in) | Machine: Enchanting Anvil |
| 7 (Structural) | Requires Forge Hall — unique building shapes (curved walls, multi-story) | Machine: Forge Hall |
| 8 (Structural) | Requires Forge Hall upgrade — batch-craft | Machine: Mass Production Line |
| 9 (Pre-Cap) | Passive: structures self-repair slowly over time | Living Timber Kit |
| 10 (Capstone) | Bulwark Form (armor/damage-reduction transformation) OR Architect's Eye (instant multi-structure placement) | Bulwark Core / Architect's Compass |

### Arcane
*Capstones: Archmage Surge (combat) vs. Ley Weaver (cozy)*

| Tier | Skill Node | Recipe / Machine Unlocked |
|---|---|---|
| 1 | Unlock basic spellcasting; +mana pool | Novice Spellbook |
| 2 | Unlock Arcane crafting station requirement flag | Machine: Arcane Workbench (basic) |
| 3 (Fork) | Elementalist (damage spells scale up) OR Utilitarian (utility spells: light, short teleport, detect) | Elemental Focus Gem / Wayfinder Charm |
| 4 | Chosen fork scales up | Elemental Rod OR Detection Lens |
| 5 (Crossover) | Auto-harvest spell (resource gathering via magic) | Harvest Sigil |
| 6 | Minor NPC charm spell (Trade/Charm tie-in) | Charm Dust |
| 7 (Structural) | Requires Arcane Altar — portals / fast travel | Machine: Arcane Altar |
| 8 (Structural) | Requires Altar upgrade — summon a minor familiar | Familiar Summoning Circle |
| 9 (Pre-Cap) | Passive mana regen boost; small AoE mana aura | Ley Anchor |
| 10 (Capstone) | Archmage Surge (burst AoE ultimate) OR Ley Weaver (passive mana fuels auto-crafting/harvesting) | Surge Core / Ley Heart |

### Wild / Beast
*Capstones: Alpha Bond (combat) vs. Menagerie Keeper (cozy)*

| Tier | Skill Node | Recipe / Machine Unlocked |
|---|---|---|
| 1 | Faster taming; +companion loyalty gain | Basic Feed |
| 2 | Unlock basic ranching (coops/pens) | Machine: Basic Pen/Coop |
| 3 (Fork) | Packmaster (multiple companions active) OR Bonded (single companion, deeper stat growth) | Pack Whistle / Bonding Charm |
| 4 | Chosen fork scales up | Second Companion Slot OR Loyalty Amplifier |
| 5 | Companion "blessing" — minor magic buff (Arcane tie-in) | Blessing Sigil |
| 6 | Ranged combat perk (agility, dodge) | Quickstep Charm |
| 7 (Structural) | Requires Stable/Sanctuary — rare creature taming | Machine: Sanctuary |
| 8 (Structural) | Requires Sanctuary upgrade — breeding mechanics | Breeding Nest |
| 9 (Pre-Cap) | Passive: all companions gain a small stat buff | Alpha Collar |
| 10 (Capstone) | Alpha Bond (companion fights at massively boosted power alongside you) OR Menagerie Keeper (unlimited companion rotation, all provide passive resource generation) | Alpha Fang / Keeper's Horn |

### Trade / Charm
*Capstones: Enthraller (combat) vs. Tycoon (cozy)*

| Tier | Skill Node | Recipe / Machine Unlocked |
|---|---|---|
| 1 | +shop sell prices; faster NPC relationship gain | Basic Market Stall |
| 2 | Unlock basic shop stall building | Machine: Shop Stall |
| 3 (Fork) | Silver Tongue (better dialogue/charm options, cheaper gifts) OR Merchant (bigger shop capacity, bulk buy/sell) | Charm Pendant / Ledger and Scale |
| 4 | Chosen fork scales up | Gift Discount Token OR Bulk Crate |
| 5 (Crossover) | Charm/debuff spell in combat (weaken or briefly ally an enemy) | Enthrall Dust |
| 6 | Price-based magic (temporarily inflate/deflate market) | Market Sigil |
| 7 (Structural) | Requires full Shop building — passive income while offline | Machine: Full Shop |
| 8 (Structural) | Requires Shop upgrade — an NPC can be hired to run the stall | Hiring Contract |
| 9 (Pre-Cap) | Passive: relationship gain boosted near the player's shop | Charisma Beacon |
| 10 (Capstone) | Enthraller (charm enemies to fight for you) OR Tycoon (shop auto-restocks, passive gold scales with relationships) | Enthraller's Mask / Tycoon's Seal |

Recurring cross-tree threads (Arcane's charm spell touches Trade; Forge's enchanting touches Arcane; Wild's "blessed
companion" touches Arcane) are intentional — they set up future node prerequisites across trees, reinforcing hybrid
builds.
