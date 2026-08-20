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

Six entries locked so far. Renaming may happen at any time — the direction is what's locked, names are easy to
revisit.

---

### Marrow — Village Blacksmith

| Field | Value |
|---|---|
| Name / Role / Location | Marrow — the Forge, in town |
| Personality traits | Steady, grounded protector. Quietly watchful and unbothered rather than tough-guy posturing — keeps everyone's gear (and by extension, everyone) safe and functional. |
| Romanceable? | No |
| Personal questline | Minimal by design |
| Confidant-tier reveal | TBD |
| World Story connection | TBD |
| Companion connection | TBD |
| Lore ancestry | TBD |
| Visual notes | Placeholder pending visual inspiration pass |
| Nature (spoiler field) | TBD |

Ties into the Forge/Craft skill tree — likely point of sale for early Forge recipes/machines (see 3.7).

---

### Thistle — Herbalist / Apothecary

| Field | Value |
|---|---|
| Name / Role / Location | Thistle — an apothecary shop, in town |
| Personality traits | Caretaker. Fussy in the best way — remembers everyone's comfort item, worries out loud, sells potions and bandages. |
| Romanceable? | No |
| Personal questline | Minimal by design |
| Confidant-tier reveal | TBD |
| World Story connection | TBD |
| Companion connection | TBD |
| Lore ancestry | TBD |
| Visual notes | Placeholder pending visual inspiration pass |
| Nature (spoiler field) | TBD |

Ties into Earth/Growth and the Alchemy system (see 8.2) — likely point of sale for potions/oils/coatings.

---

### Pip — The Dungeon Merchant

| Field | Value |
|---|---|
| Name / Role / Location | Pip — sets up shop inside the dungeon, at bracket transition points |
| Personality traits | Crisis-responder, not a background-danger figure. Upbeat and bracing rather than grim — steady specifically *because* things are hard, not despite it. |
| Romanceable? | No |
| Personal questline | Minimal by design |
| Confidant-tier reveal | TBD |
| World Story connection | TBD |
| Companion connection | TBD |
| Lore ancestry | TBD |
| Visual notes | Placeholder pending visual inspiration pass |
| Nature (spoiler field) | TBD |

Ties into 11.5's boss-reward/fast-travel loop — Pip is a plausible point of sale/service once a bracket entrance is
unlocked.

---

### Sage — Town Archivist / Librarian

| Field | Value |
|---|---|
| Name / Role / Location | Sage — the Archive/Library, in town |
| Personality traits | Memory-holder. Gentle, a little formal, deeply kind rather than eerie — holds pieces of information others don't have access to. |
| Romanceable? | No |
| Personal questline | Minimal by design |
| Confidant-tier reveal | TBD |
| World Story connection | TBD |
| Companion connection | TBD |
| Lore ancestry | TBD |
| Visual notes | Placeholder pending visual inspiration pass |
| Nature (spoiler field) | TBD |

Sells maps, books, and lore scrolls. Mechanically, Sage can tell the player about a seasonal Wild Spawn before
they've physically found it — feeding the "informationally known" map flag from 9.3, and giving that mechanic an
actual voice instead of a passive unlock.

---

### Clover — No Job

| Field | Value |
|---|---|
| Name / Role / Location | Clover — present around town, no fixed post |
| Personality traits | Pure companionship. Warm, low-stakes, simply present — the direct answer to "some of us are just here to keep us company." |
| Romanceable? | No |
| Personal questline | None — deliberately. Clover doesn't need to earn a place in the roster mechanically. |
| Confidant-tier reveal | TBD |
| World Story connection | TBD |
| Companion connection | TBD |
| Lore ancestry | TBD |
| Visual notes | Placeholder pending visual inspiration pass |
| Nature (spoiler field) | TBD |

No shop, no system tie-in, no function to justify existing — that absence is the point.

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

### Juniper — General Goods Merchant

| Field | Value |
|---|---|
| Name / Role / Location | Juniper — the General Store, in town |
| Personality traits | No-nonsense but warm trader. Capable, unflashy, keeps the basics running for everyone without making a show of it — the opposite of a greedy-merchant caricature. |
| Romanceable? | No |
| Personal questline | Minimal by design |
| Confidant-tier reveal | TBD |
| World Story connection | TBD |
| Companion connection | TBD |
| Lore ancestry | TBD |
| Visual notes | Placeholder pending visual inspiration pass |
| Nature (spoiler field) | TBD |

Point of sale for basic tools, seeds, and general supplies — the everyday commerce hub, ties loosely into Trade/Charm
without being the Trade tree's own shop-stall system (that's the player's).

---

### Fern — Stablemaster / Rancher

| Field | Value |
|---|---|
| Name / Role / Location | Fern — the Pen/Coop and, later, the Sanctuary structure |
| Personality traits | Patient, calm, an animal-whisperer type who doesn't need many words. Steady presence rather than a chatty shopkeeper. |
| Romanceable? | No |
| Personal questline | Minimal by design |
| Confidant-tier reveal | TBD |
| World Story connection | TBD |
| Companion connection | Plausible source for tamed companion guidance/feed — see Section 5 |
| Lore ancestry | TBD |
| Visual notes | Placeholder pending visual inspiration pass |
| Nature (spoiler field) | TBD |

Ties into the Wild/Beast skill tree — sells Basic Feed, oversees the Pen/Coop and Sanctuary/Breeding Nest structures
(see 3.7).

---

### Ember — Arcane Vendor

| Field | Value |
|---|---|
| Name / Role / Location | Ember — the Arcane Workbench, in town |
| Personality traits | Eccentric but approachable — delighted-nerd energy about magic rather than mysterious or sinister. Deliberately counters the "creepy occultist" trope. |
| Romanceable? | No |
| Personal questline | Minimal by design |
| Confidant-tier reveal | TBD |
| World Story connection | TBD |
| Companion connection | TBD |
| Lore ancestry | TBD |
| Visual notes | Placeholder pending visual inspiration pass |
| Nature (spoiler field) | TBD |

Ties into the Arcane skill tree — sells spell components/reagents, staffs the basic Arcane Workbench (see 3.7).

---

### Poppy — Tailor / Cosmetics Vendor

| Field | Value |
|---|---|
| Name / Role / Location | Poppy — a dress shop, in town |
| Personality traits | Playful and expressive — genuinely delights in helping people look how they want to look, no vanity-caricature undertone. |
| Romanceable? | No |
| Personal questline | Minimal by design |
| Confidant-tier reveal | TBD |
| World Story connection | TBD |
| Companion connection | TBD |
| Lore ancestry | TBD |
| Visual notes | Placeholder pending visual inspiration pass |
| Nature (spoiler field) | TBD |

Point of sale for cosmetic Clothing (see 8.3/8.4) — gives the "cosmetics as prestige reward, never power" philosophy
an actual voice in town rather than just a shop-menu category.

---

## 13.2 Romanceable / Central NPCs
**Bases only for now — personal questlines, Confidant-tier reveals, World Story connections, and Companion
connections are deliberately left TBD here.** These NPCs carry the full 6-tier Relationship Meter (4.2) and a
personal questline once that work starts; this pass is just introducing who they are.

**Romance is not gender-locked.** Every romanceable NPC is available to the player regardless of chosen gender
presentation (10.3) — consistent with clothing already being fully gender-unrestricted (10.2).

---

### Hazel — Innkeeper

| Field | Value |
|---|---|
| Name / Role / Location | Hazel — runs the Inn, in town |
| Personality traits | Warm, hospitable, a genuinely good listener. The "safe harbor" type — the Inn is a literal place of rest, and Hazel's whole presence matches that. |
| Romanceable? | Yes |
| Personal questline | TBD |
| Confidant-tier reveal | TBD |
| World Story connection | TBD |
| Companion connection | TBD |
| Lore ancestry | TBD |
| Visual notes | Placeholder pending visual inspiration pass |
| Nature (spoiler field) | TBD |

---

### Robin — Combat Trainer

| Field | Value |
|---|---|
| Name / Role / Location | Robin — a training yard, in town |
| Personality traits | Confident, encouraging mentor with playful banter energy — competent without being intimidating. |
| Romanceable? | Yes |
| Personal questline | TBD |
| Confidant-tier reveal | TBD |
| World Story connection | TBD |
| Companion connection | TBD |
| Lore ancestry | TBD |
| Visual notes | Placeholder pending visual inspiration pass |
| Nature (spoiler field) | TBD |

Plausible in-fiction source for the melee/ranged/evasion fundamentals The Rose Garden bracket teaches (10.3 in
[10-dungeons-and-risk.md](10-dungeons-and-risk.md)) — gives that early teaching moment a face, alongside Briar's
warning about what the dungeon actually costs.

---

### Iris — [Role TBD, dreamer/artistic type]

| Field | Value |
|---|---|
| Name / Role / Location | Iris — TBD location |
| Personality traits | Dreamy, artistic, poetic — likely ties to Earth/Growth or Arcane given the tone. |
| Romanceable? | Yes |
| Personal questline | TBD |
| Confidant-tier reveal | TBD |
| World Story connection | TBD |
| Companion connection | TBD |
| Lore ancestry | TBD |
| Visual notes | Placeholder pending visual inspiration pass |
| Nature (spoiler field) | TBD |

---

### Dahlia — [Role TBD, confident/social type]

| Field | Value |
|---|---|
| Name / Role / Location | Dahlia — TBD location |
| Personality traits | Confident, socially bold, charismatic — likely ties to Trade/Charm given the tone. |
| Romanceable? | Yes |
| Personal questline | TBD |
| Confidant-tier reveal | TBD |
| World Story connection | TBD |
| Companion connection | TBD |
| Lore ancestry | TBD |
| Visual notes | Placeholder pending visual inspiration pass |
| Nature (spoiler field) | TBD |

---
