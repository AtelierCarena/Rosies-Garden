# 11. Dungeons and Risk Systems

## 11.0 Entry Gate — Locked
The dungeon is not accessible from the start of the game. Its entrance, the Garden Wall (15-regions-and-zones.md,
15.2), is a ribbon-tied garden gate the player cannot open until they've found the key buried at the foot of the
weeping willow beside their Homestead house — the game's opening discovery/cutscene beat (05-character-cast.md,
6.4, discovery #1). Every system below assumes that gate has already been opened.

## 11.1 Knockout System (No Death)
Combat and hazards (falls, etc.) cost Hearts. Losing the last heart results in the player being **knocked out** and
relocated to the Town Hospital or their Homestead — Stardew/Moonlighter-style, never a fail state or permanent death.

## 11.2 Dungeon Loot-Loss on Knockout
Total dungeon depth is 200 levels — the dungeon ends there. Loss severity scales in discrete brackets rather than a
smooth curve, for easier balancing and clearer player communication ("you're entering a riskier zone now").

- **Before Level 25:** effectively risk-free — mostly just a knockout, with a small chance of losing one low-level item. A
  deliberately forgiving learning zone.
- **Level 25 onward:** gold, items, and (rarely) Legendaries become losable, ramping toward hard caps of 8,000 gold /
  4 lower-level items / 5% chance to lose a Legendary — reached only at floor 200, so the full depth range has room
  to escalate rather than plateauing at the midpoint.

| Depth Bracket | Name | Gold Loss (max) | Low-Level Items (max) | Legendary Loss Chance |
|---|---|---|---|---|
| 1-24 | The Rose Garden | 0 | 0-1 (rare chance only) | 0% |
| 25-49 | Forget-Me-Not Fields | ~1,000 | 1 | 0% |
| 50-74 | The Dollhouse | ~2,500 | 1-2 | 1% |
| 75-99 | The Opera House | ~4,000 | 2 | 2% |
| 100-124 | Porcelain Orchards | ~5,000 | 2-3 | 2.5% |
| 125-149 | Her Hollow | ~6,000 | 3 | 3% |
| 150-174 | Ballerinas Catacombs | ~7,000 | 3-4 | 3.5-4% |
| 175-199 | The Cradle Graveyard | ~7,500 | 4 | 4.5% |
| 200 | The Trellis | 8,000 (cap) | 4 (cap) | 5% (cap) |

Floor 200 is a single unique finale floor, not a 25-level bracket like the rest of the table — see 11.4.

## 11.3 Enemy Difficulty Curve
Enemy difficulty scales continuously level-by-level within a bracket (so no floor ever feels flat), layered with three
scripted beats per bracket that give the curve shape and teach new skills:

1. **Bracket-start:** a new baseline enemy archetype is introduced.
2. **Bracket-midpoint (~halfway through):** a mini-boss appears, alongside one or two new enemies at varying
   difficulty — sometimes reinforcing a skill from an earlier bracket at higher stakes, sometimes introducing a
   genuinely new wrinkle.
3. **Bracket-end:** a full boss, themed to the bracket, gates progression into the next bracket (see 11.5).

The Rose Garden (the first bracket) front-loads the fundamentals — melee, ranged/swarm, and evasion — since these
skills also get used outside the dungeon, in the overworld. Later brackets build on that foundation rather than
introducing basic mechanical concepts for the first time deep into the dungeon.

| Bracket | Name | Power Range (start→end) | Bracket-Start Enemy | Midpoint: Mini-Boss + New Enemies | End-of-Bracket Boss |
|---|---|---|---|---|---|
| 1-24 | The Rose Garden | 1x → 1.3x | Thorned Sprout — basic melee | Mini-boss + Pollen Wisp (easy ranged/swarm) + Bramble Stalker (slow, hits hard — teaches evasion/spacing) | **The First Thorn** — simplest boss, teaches telegraphed attacks and phases |
| 25-49 | Forget-Me-Not Fields | 1.3x → 1.7x | Forgetful Wisp — heavier ranged/swarm | Mini-boss + Wilting Hound (fast chaser — pressure-tests evasion) | **The Unremembered** — wisp-swarm controller |
| 50-74 | The Dollhouse | 1.7x → 2.2x | Broken Doll — tanky melee | Mini-boss + Porcelain Nanny (easy support/buffer — teaches "kill the support first") + Wind-Up Soldier (medium) | **Nanny** — an oversized escalation of the Porcelain Nanny |
| 75-99 | The Opera House | 2.2x → 2.8x | Marionette — charm/debuff | Mini-boss + Understudy (mimics the player's last-used attack, hard) | **The Maestro** — commands the marionettes |
| 100-124 | Porcelain Orchards | 2.8x → 3.5x | Glass Bloom — brittle, high-damage/low-HP | Mini-boss + Shard Wasp (fast, low-HP swarm) + Kiln Warden (tanky, shields nearby enemies — reinforces focus-fire priority) | **The Kiln Mother** — makes the glass enemies |
| 125-149 | Her Hollow | 3.5x → 4.3x | Thorn Knight — armored elite | Mini-boss + Hollow Widow (ambush/stealth, hard — first real "gotcha" enemy) | **The Hollow Queen** |
| 150-174 | Ballerinas Catacombs | 4.3x → 5.2x | Chorus Dancer — fast, medium | Mini-boss + Corps de Ballet (fast pack, medium) + Conductor (buffs nearby enemies — mirrors the Dollhouse's support-priority lesson at higher stakes) | **Prima** — the lead, promoted from elite to full boss |
| 175-199 | The Cradle Graveyard | 5.2x → 6.2x | Wailing Cradle — haunting swarm spawner | Mini-boss + Forgotten Nurse (heals/revives other enemies, hard) | **The Keening Mother** |
| 200 | The Trellis | 6.2x (approach only) | Trellis Guardians defend the approach | — no mini-boss/boss pattern; see 11.4 for what floor 200 actually is | — |

## 11.4 Floor 200 — The Trellis
Trellis Guardians defend the approach to floor 200, keeping the dungeon's mechanical loop intact right up to the end
— but reaching Rose herself is not a boss fight to win. No combat with her, no rescue-through-conquest framing.

The tone here is deliberately not Sleeping Beauty — not a romantic slumber waiting to be broken by a kiss. It's
quieter and stranger than that: soft light and muffled sound looping without end, roses blooming out of any season's
rhythm, thorns that curl without menace. Time doesn't move here so much as hang. Rose is at the center of it,
protected and serene — but the space itself doesn't behave like a place. It behaves like a dream that hasn't ended,
and nothing about it is waiting to be broken. Trapped in a dream, not waiting for rescue.

Her locket and diary are found there. This resolves the open question of Rose's present-day status (see her Open
Threads in [05-character-cast.md](05-character-cast.md)): she isn't a roaming spirit, she's asleep at the heart of
her own garden.

## 11.5 Boss Rewards and Fast Travel
- **Boss defeated (end of bracket):** a full reward — an item, skill-tree point progression, and a trait selection —
  plus a fast-travel point unlocks at the *next* bracket's entrance. Beating the boss at the end of 125-149 (Her
  Hollow), for example, unlocks fast travel to floor 150 — the player still has to walk in and actually reach 150
  once to activate it, fast travel isn't retroactive for a bracket never reached.
- **Mini-boss defeated (bracket midpoint):** a smaller reward from the same categories (item / skill progression /
  trait selection), scaled down from the end-of-bracket boss reward.
- Fast travel points accumulate per save file — once unlocked, a bracket entrance stays available for the rest of
  that save regardless of later knockouts (loot-loss per 11.2 affects gold/items/Legendaries carried at the time of
  knockout, not unlocked fast-travel points).

## 11.6 Bracket Flavor Naming
The naming pattern pairs a familiar, easily-read location noun with a small childhood/keepsake object — the
discomfort comes from the pairing, not obscure vocabulary. The dungeon reads as a garden's descent into rot, tying
directly into Rose's own imagery (see [05-character-cast.md, 6.4](05-character-cast.md)) rather than generic fantasy
dungeon naming.

- **The Dollhouse** and **The Opera House** are still their original terrain underneath the name (a bog and a marsh,
  respectively) — the flavor name doesn't change the ground type, just what the player is told.
- **The Opera House** carries a specific unspoken idea: someone was forced to perform there, suffering so others
  could smile.
