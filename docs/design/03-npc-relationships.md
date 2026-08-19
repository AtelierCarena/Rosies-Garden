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
- **Conditional events** — require a tier PLUS an external condition (season, weather, or the player's progress in a
  specific skill tree), layering relationship depth on top of the other systems for richer, less predictable pacing than
  pure meter-climbing.
