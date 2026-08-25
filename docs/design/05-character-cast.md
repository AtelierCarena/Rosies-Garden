# 6. Character Cast System

## 6.1 Three Categories

| Category | Definition |
|---|---|
| Interactive NPCs | Villagers the player actually talks to/gifts/quests with. Large cast planned. Mostly role-based (Merchant, Blacksmith, Healer/Mystic, Farmer, etc., tied to Trade/Forge/Arcane/Earth systems), with a handful of pure-personality NPCs with no mechanical role. A subset is romanceable; the rest are friendship-only. EVERY Interactive NPC gets a personal questline — flagged as the single biggest content-production commitment at this cast size. |
| Lore-Referenced Characters | Mentioned in books, dialogue, cutscenes, or environmental storytelling, but never met directly. No relationship meter. Cheap, high-impact worldbuilding depth. Delivered via sequential environmental discovery chains that unlock fixed-order cutscenes (see Rose, 6.4). |
| Companions | See Section 5. Have their own lore even though mechanically distinct from Interactive NPCs. |

**Named but not yet templated:** Wren, the wandering Peddler tied to the single-tree respec mechanic (see
[02-skill-trees.md, 3.4](02-skill-trees.md)). She's a strong Interactive NPC candidate — a wandering-schedule
role naturally supports a personal questline — but her full template (personality, gift preferences, romanceable
status, etc.) is deferred to the roster pass.

## 6.2 Interactive NPC Template — Expanded

| Field | Purpose |
|---|---|
| Name / Role / Location | Identity + system tie-in if role-based |
| Personality traits | Gift preferences, neglect-sensitivity flag, dialogue voice |
| Romanceable? | Yes / No |
| Personal questline | Multi-stage, tied to relationship tiers |
| Confidant-tier reveal | What lore/backstory unlocks at trust |
| World Story connection | What do they know, guard, or witness re: the fixed lore track |
| Companion connection | Do they gift, sell, or bond a companion to the player? |
| Lore ancestry | Is this NPC connected to a Lore-Referenced figure (e.g. a descendant)? |
| **Connections** | Which other Interactive NPCs they know, why, and what it changes mechanically — a shared discount, a joint dialogue scene, a quest that only unlocks once both parties are at a given tier, a gift-preference overlap, etc. Interconnection is the point, not a nice-to-have — every entry should name at least one tie. |
| **Dungeon Role** | Dungeon Escort or NPC-Granted Creature Companion — see [03-npc-relationships.md, 4.6](03-npc-relationships.md). Decided per-NPC based on whether their trade translates into direct dungeon action. |
| **Dungeon Ability** | The specific signature ability, its trigger condition, and cooldown/limit. |
| **Attributes** (Escort only) | HP / Power / Speed stat block — combat viability as a Dungeon Escort. Not needed for Companion-Granters, whose granted creature carries its own Companion stats (04-companions.md). |
| Species | Human / Elf / Fairy / Pixie / Orc / Animal-hybrid (specify trait, e.g. "rabbit ears") / TBD. Not uniform across the roster; decided per-NPC, tied to personality rather than assigned generically. |
| **Physical Reference** | Height, build/measurements, eye/hair color, and other concrete art-reference details — distinct from Visual notes' outfit/vibe description. For the player's own sketching/character reference use. |
| Visual notes | Outfit, vibe, signature accessories/props |

**Rollout note:** the expanded fields (Connections, Dungeon Role, Dungeon Ability, Attributes, Physical Reference)
are being backfilled across the roster incrementally — 12-npc-roster.md tracks which entries are fully upgraded vs.
still on the pre-expansion template.

## 6.3 Companion and Lore-Referenced Character Templates

**Companion Field**

| Field | Purpose |
|---|---|
| Name / Species or Origin | Tamed creature-type, or story-given named character |
| Type | Tamed (loyalty meter) or Story-given (full 6-tier meter) |
| Source | How obtained — taming, NPC gift, story milestone |
| Combat/utility role | How they function under Wild/Beast tree buffs |
| Lore | Species lore (tamed) or personal backstory (story-given) |
| Personality traits | Especially for story-given companions |

**Lore-Referenced Field**

| Field | Purpose |
|---|---|
| Name / Title | Identity |
| Where referenced | Book, dialogue, ruins, cutscene |
| World Story role | Historical figure, absent character, myth/legend, political figure |
| Linked NPC(s) | Which living Interactive NPCs (if any) descend from or relate to this figure |
| Symbolic role | What the figure represents thematically, even if also literal |

## 6.4 Worked Example: Rose (Lore-Referenced Character)
Rose is the proof-of-concept for the discovery -> cutscene delivery pattern used for Lore-Referenced Characters. Her
arc is a rose-as-a-person allegory delivered in fixed order, each stage unlocked by a physical world discovery rather
than a quest marker or relationship meter.

### Discovery Chain

| # | Discovery | Cutscene |
|---|---|---|
| 1 | A key is found in a box buried under a mound of disturbed dirt at the foot of a weeping willow tree — this tree always spawns next to the player's house regardless of where on the Homestead the house itself lands, so no player can miss it. | Intro: Rose sprouts alone in a small patch of soil surrounded by toxic soil. Uneasy, visibly juvenile, an air of innocence. She grows slowly, unsure. |
| 2 | Player discovers a hidden gate to a garden. | A Gardener finds her, reaches out, and begins plucking her flowers to sell — flattering at first, growing more intense and demanding, hurting her for his own gain. |
| 3 | Player discovers a small babydoll under a weeping willow in the garden. | A child stumbles into the garden, sees her sitting sadly with her babydoll, and sits to keep her company. He returns every day; she seems happy for the first time. |
| 4 | TBD — see options below. | She asks to leave with him. He says it isn't a good idea, tells her she deserves more than he can provide, and leaves. She waits, as always. He does not come back. The gate creaks open: the Gardener returns, a Florist peers over the wall, a Wolf watches from the bush, a Snake slithers up a tree — all staring at Rose. She sinks down, scared. Fade to black. |

**4th discovery item — TBD.** Candidates discussed: a wilted flower pressed in a book; a torn piece of fabric caught on
the garden fence; a muddy footprint frozen in old clay/stone facing away from the garden; a rusted bell. The footprint
and the bell lean strongest, since both let the object hint at departure/waiting before the scene even plays — matching
how the key/gate/babydoll each quietly matched their own scene's content.

**The key's mechanical payoff — Locked.** This isn't just a cutscene trigger — it's the literal dungeon-unlock
item. The gate it opens is a **ribbon-tied garden gate**, closed shut, which is the Garden Wall — the dungeon's
entrance at the back of the Hills (10-dungeons-and-risk.md; 15-regions-and-zones.md, 15.2). The player cannot enter
the dungeon at all until they've found the willow key, meaning the very first cutscene of the game (Rose's
sprouting) and the mechanical act of unlocking the dungeon are one and the same discovery. Two weeping willows now
exist in the world — this one beside the player's house, and the one in Rose's own garden where the babydoll is
found (discovery #3) — kept deliberately distinct locations, the recurring tree read as an intentional motif
rather than a contradiction.

### The Five Figures — Resolved
All five figures in the final scene (Gardener, Child, Florist, Wolf, Snake) are **purely symbolic — none are tied
to any current Interactive NPC or their ancestors.** The Gardener already set this precedent (Linnet's title was
changed specifically to avoid colliding with him, 12-npc-roster.md); the same protection now extends to all five,
especially Florist and Child. A warm, romanceable NPC like Ophelia secretly being one of the four figures closing
in on Rose in her most frightening scene would retroactively poison her characterization; Child's vanished bond is
more powerful staying ambiguous (dovetailing with 06-storyline-structure.md 7.1's deliberately undefined "who is
the player") than pinned to one NPC's backstory. See 06-storyline-structure.md, 7.2-7.3 for the broader rule this
follows: no Interactive NPC's Nature should ever be inferable from their role or personality.

### Rose and Rosie — Resolved
"Rosie" is her childhood nickname. Rose is the core — the purest, most innocent version of her, from before the
trauma happened. See [06-storyline-structure.md, 7.1](06-storyline-structure.md) for the full context.

### Rose's Present-Day Status — Resolved
Rose is present, not purely past-tense. She rests beneath **The Trellis**, the 200+ depth bracket at the bottom of the
main dungeon (see [10-dungeons-and-risk.md, 11.3](10-dungeons-and-risk.md)) — cocooned and protected by beds of
roses and thorns, weeping peacefully in eternal slumber. Her locket and diary are found there. She is not a roaming
ghost/spirit the player interacts with directly; she's a fixed, sleeping presence at the heart of her own garden,
discovered rather than engaged with — consistent with her category as a Lore-Referenced Character (no relationship
meter, no direct interaction).
