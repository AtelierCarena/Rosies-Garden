# 13. Interactive NPC Roster

The full Interactive NPC roster, built incrementally (per [05-character-cast.md, 6.1](05-character-cast.md), this was
paused deliberately to manage scope/pacing — this doc is where that work actually happens once it starts).

Uses the Interactive NPC Template from 05-character-cast.md, 6.2. The **Nature (spoiler field)** — Literal Alter /
Ambient Figure / TBD, per [06-storyline-structure.md, 7.1](06-storyline-structure.md) — is never player-facing and
exists for internal consistency only.

## 13.1 Functional, Non-Dateable NPCs
This category starts with the NPCs who fill specific functional roles in the world — shopkeepers, the dungeon
merchant, and similar — without being tied to the main World Story track and without being romanceable. Not every
NPC in the mind space is a host or carries a personal questline arc the way a romanceable/central NPC would; some are
here simply to fill their function, or simply to keep the space from being lonely. Both are valid and neither is
lesser.

**Design intent for this category:** these are archetypal roles, not literal 1:1 depictions of anyone real — built to
push back on how DID gets flattened into caricature in most media (the "evil alter" trope, or media that leans only
into the worst parts and does none of the work to explore the rest). Every entry here should read as competent,
warm, and dignified, even when a personality is prickly on the surface — never "the scary one," never spectacle for
its own sake.

**Proposed batch (names/details pending confirmation, except Briar below which is locked):**
- **Marrow** — Village Blacksmith. A steady, grounded protector — keeps everyone's gear (and by extension,
  everyone) safe and functional. Ties into the Forge/Craft tree.
- **Thistle** — Herbalist/Apothecary. A caretaker; fussy in the best way, remembers everyone's comfort item, sells
  potions and bandages.
- **Pip** — The Dungeon Merchant. A crisis-responder, not a background-danger figure — sets up shop at bracket
  transitions inside the dungeon (ties into 11.5's reward/fast-travel loop), steady specifically *because* things are
  hard, not despite it.
- **[Name TBD]** — Town Archivist/Librarian. A memory-holder; sells maps, books, and lore scrolls, and can tell the
  player about a seasonal Wild Spawn before they've found it themselves (feeds the "informationally known" map flag
  in 9.3).
- **[Name TBD]** — no job at all. Pure companionship, present around town with no function to justify existing —
  the direct answer to "some of us are just here to keep us company." Deserves a place in the roster without needing
  to earn it mechanically.

---

### Briar — Dungeon Gatekeeper / Town-Side Watchman

| Field | Value |
|---|---|
| Name / Role / Location | Briar — stationed at the dungeon entrance, in town, at the threshold before floor 1 |
| Personality traits | Grumpy-because-he-cares, played all the way through rather than as a one-note bit — gruff, visibly reluctant to say anything sentimental out loud, but always follows through with action. Independent (not neglect-sensitive per 4.4) — he'd never admit to needing anyone else's attention. |
| Romanceable? | No |
| Personal questline | Minimal by design (functional-NPC category), but carries a recurring mechanical/narrative beat (see below) that deepens with repeated interaction rather than a full multi-stage arc |
| Confidant-tier reveal | TBD — likely reveals what he's actually protecting against/why, once more of the World Story is built out |
| World Story connection | TBD |
| Companion connection | TBD |
| Lore ancestry | TBD |
| Visual notes | Placeholder pending visual inspiration pass |
| Nature (spoiler field) | TBD, leaning Literal Alter given the narrative weight — not locked |

**Signature mechanic — Warn, Carry, Snack:**
1. **Warning.** Before a player's first dungeon entry (and available as a repeatable dialogue line after), Briar
   gives an in-fiction version of the loot-loss risk info from 11.2 — knockout risk, losing your things, don't be
   stupid about it — replacing a dry system tooltip with an actual voice.
2. **Knockout rescue cutscene.** Any knockout that happens inside the dungeon triggers a short cutscene: Briar
   grumbling the entire way while physically getting the player home. Loot-loss per 11.2 still applies in full —
   this is a narrative layer on top of the existing system, not a mechanical override.
3. **Aftermath note.** The next time the player heads back toward the dungeon, they find a snack waiting (a Food
   item per 9.1, restores Hearts on use) with a handwritten note: *"Here, take this next time you go out. Maybe I
   won't have to carry you home next time."*

---
