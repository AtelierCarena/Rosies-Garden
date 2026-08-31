# 4. NPC Relationship System

## 4.1 Overview
Covers Romance, Friendship, Gift-giving, and milestone-triggered events. This is the mechanical skeleton every NPC
plugs into; individual NPC personalities/dialogue are designed separately (see Section 6, Character Cast System).

## 4.2 Relationship Meter — 6 Tiers

| Tier | Label | Typical Trigger |
|---|---|---|
| 0 | Stranger | First meeting |
| 1 | Acquaintance | A few interactions/dialogue exchanges |
| 2 | Friend | Regular gifts/talks; a small quest completed |
| 3 | Close Friend | Sustained interaction; a bigger quest/favor |
| 4 | Confidant | Deep trust threshold — personal lore/backstory unlocks here for every NPC |
| 5a / 5b | Best Friend (platonic) OR Romance-eligible -> Partner | Fork based on player pursuit |

## 4.3 Interaction Types (Feed the Meter)
- **Dialogue** — daily greeting/chat; small flat gain with diminishing returns if repeated same day (prevents
  spam-talking to grind the meter).
- **Gift-giving** — loved/liked/neutral/disliked/hated tags per NPC; larger swings than dialogue, capped per week per
  NPC.
- **Quest/Favor completion** — the largest single gains, tied to that NPC's personal questline.
- **Shared activity** — inviting an NPC to fish, farm alongside the player, or visit their base; ties relationships
  mechanically into the farming/building systems rather than staying a pure dialogue menu.

## 4.4 Decay Rules
- **Default:** meters only grow or stay flat — no decay from simple neglect.
- **Universal:** any NPC can lose meter from an action that specific character dislikes (a disliked gift, a rude dialogue
  choice, breaking a promise).
- **Neglect-sensitive NPCs:** a subset of NPCs ALSO decay from being ignored for a stretch of time — this is a
  per-character personality trait (e.g. "Clingy"/"Anxious" = neglect-sensitive; "Independent" = does not care), not a
  global rule.
- **Romance regression:** permanent/stable once achieved, EXCEPT via a major negative story event (betrayal, a
  significant story choice, a companion's personal questline going wrong) — never from day-to-day neglect or a single
  bad gift.

## 4.5 Event Triggers
- **Threshold events** — fire once, automatically, the moment a meter crosses a tier boundary.
- **Conditional events** — triggered purely by an external world-state condition, unrelated to and not gated behind
  meter tier at all (e.g. interacting with a specific tree in the woods on a Friday in Year 2). Independent from
  tier-scaling entirely — a conditional event can fire for a Stranger-tier NPC just as easily as a Confidant-tier
  one, since it's the world-state condition doing the gating, not relationship progress. This layers a second,
  unpredictable discovery axis on top of the meter's steady climb rather than compounding with it.

## 4.6 Dungeon Companions — Locked
At **Tier 4 (Confidant)**, the player can ask an eligible NPC to join them in the dungeon. Tier 4 was chosen
deliberately over the later romance-fork tiers (5a/5b) — the dungeon is a core part of village life, not a romance
reward, so the unlock sits at the "deep trust" threshold everyone can reach regardless of romance path.

Every Interactive NPC falls into exactly one of two tracks, decided per-NPC based on whether their trade translates
into direct dungeon action:

**Dungeon Escort** — the NPC physically accompanies the player into the dungeon and performs an autonomous,
role-flavored action on a trigger/cooldown (e.g. a Chef auto-foraging ingredients and cooking Food once enough are
collected; a Miner auto-harvesting ore nodes the party passes). Reserved for NPCs whose trade has an obvious
dungeon-useful translation — combat, crafting, healing, or resource-gathering roles mostly.

**NPC-Granted Creature Companion** — for an NPC whose trade doesn't translate directly (a Perfumer, a Beekeeper),
reaching Tier 4 instead bestows a themed creature Companion (04-companions.md) that fights or assists on the NPC's
behalf, carrying their trade's flavor into a form the dungeon can actually use. The NPC themselves never enters the
dungeon; the roster isn't cut down to "useful" and "unused" halves, every Confidant-tier NPC contributes something.

Both tracks share:
- **One active Escort/Companion at a time** — the player picks who joins per dungeon run, not a full party.
- **Knockout ties into the loot-loss system (11.2):** an Escort or Companion can be "downed" mid-run (separate HP
  pool, see per-NPC Attributes) without ending the run — they simply stop acting until the player reaches a safe
  point (bracket transition, Nix's shop, town return).
- **Ability cooldowns/limits** exist specifically so no Escort ability can be spammed into trivializing a bracket's
  intended difficulty curve (10-dungeons-and-risk.md, 11.3).

Full per-NPC assignment (Escort vs. Companion-Granter) and ability design lives in the NPC Roster
(12-npc-roster.md), using the expanded Interactive NPC Template (05-character-cast.md, 6.2).

## 4.7 Romance, Proposal, and Marriage — Locked
Pins concrete tiers to the 4.2 fork rather than leaving "Romance-eligible" abstract:

- **Romance eligibility unlocks at Tier 4, Confidant** — the same tier that already gates the personal lore/
  backstory reveal (4.2) and Dungeon Companion access (4.6). No separate romance-specific threshold; reaching
  Confidant opens the fork to pursue Tier 5b (Partner) instead of settling at 5a (Best Friend).
- **Tier 5b, Partner** is "full friendship plus romance" — the prerequisite for Proposal.
- **Proposal** becomes available once a player reaches Tier 5b with an NPC. There's no rejection state modeled —
  by the time a player reaches Partner tier, acceptance is guaranteed, keeping the moment a celebration rather
  than another skill check.
- **Marriage** takes place automatically **one in-game week (7 days) after Proposal** — no player-run ceremony
  planning, no additional gate. The wait exists purely for pacing/anticipation, not as a resource or quest gate.

This tier ladder is shared with the specialty-shop selling bonus (07-item-system.md, 8.7) — Tier 2 ("half
friendship") and Tier 5a/5b ("full friendship") aren't just Romance milestones, they're also when a matching
specialty shopkeeper's price bonus steps up. Relationship investment pays off in flavor, dungeon utility, and
economy all off the same meter, rather than three separate tracking systems.
