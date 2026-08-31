# 7. Storyline Structure

Two parallel storyline tracks run simultaneously and are kept deliberately separate:

| Track | Definition |
|---|---|
| 1. World Story (the Game's Storyline) | Fixed lore delivered over time via cinematic cutscenes with music. This is the world's history — discovered by the player, never altered by player choice. Delivered in part via Lore-Referenced Character discovery chains (see Rose, 6.4) and other narrative milestones. |
| 2. Player Story (the Player's Experience) | Emergent and personal: NPC interactions and choices the player makes. This track cannot change the world's pre-existing history — it only affects LATER game events, coloring the individual playthrough without rewriting fixed lore. |

This split keeps background lore consistent across every save file while still letting individual playthroughs feel
personal and reactive.

## 7.1 The True Nature of the World (Central Twist — Developer Reference, Not Player-Facing)
**This section describes the game's ending reveal. It exists so every other system can be built consistently toward
it — none of this is exposed to the player until the reveal lands.**

The world is Rosie's Garden in the most literal sense: the entire game map is the mind space Rosie's mind built to
protect her from an intense, specific trauma. What plays as a cozy farming/adventure world for most of the runtime is
revealed to be the inside of a traumatized girl's mind — and the player has been living inside it, interacting with the
pieces of her, the whole time.

**Reveal pacing:** seeded early, confirmed late. Rose's discovery chain (6.4) is the template — it already reads as a
trauma allegory (an exploiting adult, a caring bond that vanishes without explanation, threatening figures closing in)
without ever stating what it is. Other environmental/NPC details should plant the same kind of quiet wrongness
throughout the world without confirming anything, so the ending recontextualizes what came before rather than
introducing new information.

**Who the player is:** deliberately left undefined. The game never states whether the player is Rosie herself, an
outside visitor who entered her mind space, or a passive part/alter present to help her process what happened in the
background. All three readings stay valid and are never contradicted by the text — the ambiguity of "who is doing the
experiencing" is thematically load-bearing, not a gap to fill in later.

**Interactive NPCs — Resolved:** no individual NPC is mechanically flagged or typed as a "literal alter" vs. an
"ambient figure." Every resident of the town is written and played as an ordinary person, full stop — the earlier
plan to tag each NPC's Nature per-entry (a field on the Interactive NPC Template, 6.2) has been dropped entirely,
not just decoupled from personality. The ambiguity of what the space *is* works precisely because it's never
resolved anywhere, including in dev-only docs — there's no hidden answer key naming who's "really" a part of
Rosie and who isn't. The reveal lives entirely in the delivery layer (7.3), never in how any individual character
is classified.

**Rose and Rosie — confirmed:** "Rosie" is her childhood nickname. Rose is the core — the purest, most innocent
version of her, from before the trauma happened. Her discovery chain is the origin wound the rest of the mind space
was built around; The Trellis, where she sleeps cocooned in roses and thorns (see
[10-dungeons-and-risk.md, 11.3](10-dungeons-and-risk.md)), is the most deeply protected place in her mind because
it holds the most vulnerable, most guarded part of her — the part from before.

**A note on handling this well:** this is real, sensitive subject matter. Worth treating with the same care other
media that's handled dissociation/trauma respectfully has used (Celeste, Hellblade, Sea of Solitude are useful
reference points) — avoiding tropes that frame parts/alters as inherently monstrous or as something to be "defeated,"
and keeping the focus on protection and process rather than spectacle. Doesn't need to be solved now, just kept in
mind as the NPC roster and ending get built out.

## 7.2 No Per-NPC Typing — Locked Ground Rule
**No NPC is ever classified, even privately in dev docs, as a "literal alter" vs. an "ambient figure."** A role
that happens to thematically parallel a psychological function (a memory-keeper, a caretaker, a protector) is
coincidence, not a signal — the writing stays agnostic to it. **The whole town plays completely straight** —
ordinary, warm, specific people — with zero tell, and zero hidden designation anywhere behind the scenes. The
reveal doesn't live in the NPCs at all; it lives entirely in the separate delivery layer below.

## 7.3 Reveal Delivery Mechanisms — Locked
The central twist surfaces exclusively through discovery, not through any NPC ever acting or speaking as if they
know what they are. Several parallel channels, layered across the whole runtime rather than dumped near the
ending:

- **Memory Notes/Items.** Found objects — diary pages, letters, small keepsakes — scattered through the world and
  the dungeon, each surfacing a fragment of Rosie's real history. Rose's locket and diary at the Trellis
  (05-character-cast.md, 6.4) are the anchor example; more should exist earlier and lower-stakes, seeded well
  before the ending the same way Rose's own discovery chain plants quiet wrongness without confirming anything
  (7.1).
- **Conditional Events.** The world-state-gated event system (03-npc-relationships.md, 4.5 — unrelated to
  relationship tier) is a natural vehicle for memory-fragment beats tied to a specific place, day, or season,
  the same mechanical shape already used for lighter content (a tree in the woods on a specific day).
- **Companion-carried fragments.** Story-Given Companions especially (Thornwyrm, Lumen — 04-companions.md, 5.2)
  are well-positioned to surface pieces of the truth as their bond deepens, given their own discovery-chain origin
  already ties them to something larger than a simple tame.
- **Ambient Rosie Sightings — new, Locked.** Distinct from Rose's formal discovery chain (which is deliberate,
  staged, and confirms new information each time): occasional, easy-to-miss glimpses of a young girl in a
  flowerbed somewhere in the world, unconfirmed and unremarked on by any NPC. No prompt, no marker, nothing
  forcing the player to notice — pure atmosphere that only clicks into meaning in hindsight, once the ending
  recontextualizes it. Should appear rarely enough that finding one feels like a private, slightly eerie moment
  rather than a collectible.
- **Two distinct cutscene art styles — new, Locked.** Tutorial and NPC-relationship cutscenes (Silas's fishing
  lesson, romance scenes, milestone events) use the game's normal cozy visual language throughout. **World
  Story/memory-reveal cutscenes use a deliberately different art style** — more painterly, dreamlike, or
  dissociative-coded than the everyday register. The shift itself is a storytelling tool: the player registers
  "this moment is different" on a visual/subconscious level before they consciously understand why, reinforcing
  the twist without a single line of dialogue doing it for them.

## 7.4 Memory Notes/Items — First Batch, Locked
Each a plain, ordinary object first — nothing narrated as significant, no dialogue calling attention to it — only
reading as more than that in hindsight, once the ending recontextualizes it. Placed across existing zones
(15-regions-and-zones.md, 15.1), spread out rather than clustered.

| Item | Location | What the player sees |
|---|---|---|
| A pressed flower in a borrowed book | The Homestead, on a bookshelf | Gone brittle-thin, tucked at the same page every time the book is opened |
| A child's height marked in pencil on a doorframe | The Inn | The marks stop partway up, mid-childhood, never finished |
| A torn ticket stub | Near the Train Station, half-buried | For a place that doesn't appear anywhere on the map |
| A single mitten | Snagged on the fence near the Garden Wall | No pair, no owner, weathered like it's been there a long time |
| An unlit, unused birthday candle | A drawer at the Inn | The wrong number of them for any age that makes obvious sense |
| A folded crayon drawing | The Hidden Forest | A house, a sun, two stick figures holding hands — one figure scribbled out later, in a different color of crayon |

More Memory Notes are expected as the World Story track develops further — this batch establishes the pattern
(ordinary object, specific and slightly wrong detail, no explanation) rather than being the complete set.
