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

**Interactive NPCs:** mixed nature, not a uniform 1:1 clinical mapping. Some are literal parts/alters of Rosie holding
a distinct role in how her mind protects her; others simply exist in the space under dream/mind-space logic, without
being a specific "part" of anything. Which is which per-NPC gets decided during the roster pass (see 6.1) — the
Interactive NPC Template (6.2) should carry a field for this once that work starts.

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

## 7.2 Nature Assignment — Locked Ground Rule
**The Nature field must never be inferable from an NPC's personality, dialogue, or role during normal play.** An
NPC whose job or personality thematically parallels a psychological function (a memory-keeper, a caretaker, a
protector) is a coincidence the writing should stay agnostic to, never a signal — assigning Nature based on "this
role obviously reads symbolic" is explicitly the wrong approach, since it would make individual NPCs legible as
alters through characterization alone. **The whole town has to play completely straight** — ordinary, warm,
specific people — with zero tell. The reveal doesn't live in the NPCs at all; it lives entirely in the separate
delivery layer below.

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

Nature field values (Literal Alter/Ambient Figure per-NPC) remain genuinely undecided and can now be assigned
freely, since they no longer need to correlate with how any NPC reads on the surface — that decoupling is the
point.
