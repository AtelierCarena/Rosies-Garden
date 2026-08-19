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

## 6.2 Interactive NPC Template

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
| Visual notes | Placeholder pending visual inspiration pass |

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
| 1 | A key is found in a box buried under disturbed soil, near a tree next to the player's spawn house. | Intro: Rose sprouts alone in a small patch of soil surrounded by toxic soil. Uneasy, visibly juvenile, an air of innocence. She grows slowly, unsure. |
| 2 | Player discovers a hidden gate to a garden. | A Gardener finds her, reaches out, and begins plucking her flowers to sell — flattering at first, growing more intense and demanding, hurting her for his own gain. |
| 3 | Player discovers a small babydoll under a weeping willow in the garden. | A child stumbles into the garden, sees her sitting sadly with her babydoll, and sits to keep her company. He returns every day; she seems happy for the first time. |
| 4 | TBD — see options below. | She asks to leave with him. He says it isn't a good idea, tells her she deserves more than he can provide, and leaves. She waits, as always. He does not come back. The gate creaks open: the Gardener returns, a Florist peers over the wall, a Wolf watches from the bush, a Snake slithers up a tree — all staring at Rose. She sinks down, scared. Fade to black. |

**4th discovery item — TBD.** Candidates discussed: a wilted flower pressed in a book; a torn piece of fabric caught on
the garden fence; a muddy footprint frozen in old clay/stone facing away from the garden; a rusted bell. The footprint
and the bell lean strongest, since both let the object hint at departure/waiting before the scene even plays — matching
how the key/gate/babydoll each quietly matched their own scene's content.

### Open Threads
- The five figures in the final scene (Gardener, Child, Florist, Wolf, Snake) are a mix of purely symbolic figures and
  figures tied to real Interactive NPCs or their ancestors — which is which is not yet assigned. Needs a tracking flag
  once the NPC roster exists.
- Rose's present-day status is undecided — her story may stay entirely in the past (discovery-only), or she may still
  be present in some form (a ghost/spirit tied to the location) the player could eventually interact with. Flagged for
  revisit once more of the world/cast exists.
