# 11. Dungeons and Risk Systems

## 11.1 Knockout System (No Death)
Combat and hazards (falls, etc.) cost Hearts. Losing the last heart results in the player being **knocked out** and
relocated to the Town Hospital or their Homestead — Stardew/Moonlighter-style, never a fail state or permanent death.

## 11.2 Dungeon Loot-Loss on Knockout
Total dungeon depth is 200+ levels. Loss severity scales in discrete brackets rather than a smooth curve, for easier
balancing and clearer player communication ("you're entering a riskier zone now").

- **Before Level 25:** effectively risk-free — mostly just a knockout, with a small chance of losing one low-level item. A
  deliberately forgiving learning zone.
- **Level 25 onward:** gold, items, and (rarely) Legendaries become losable, ramping toward hard caps of 8,000 gold /
  4 lower-level items / 5% chance to lose a Legendary — reached only at the 200+ bracket, so the full 200+ level range
  has room to escalate rather than plateauing at the midpoint.

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
| 200+ | The Trellis | 8,000 (cap) | 4 (cap) | 5% (cap) |

## 11.3 Bracket Flavor
The naming pattern pairs a familiar, easily-read location noun with a small childhood/keepsake object — the
discomfort comes from the pairing, not obscure vocabulary. The dungeon reads as a garden's descent into rot, tying
directly into Rose's own imagery (see [05-character-cast.md, 6.4](05-character-cast.md)) rather than generic fantasy
dungeon naming.

- **The Dollhouse** and **The Opera House** are still their original terrain underneath the name (a bog and a marsh,
  respectively) — the flavor name doesn't change the ground type, just what the player is told.
- **The Opera House** carries a specific unspoken idea: someone was forced to perform there, suffering so others
  could smile.
- **The Trellis** (200+, the bottom) is where Rose's locket and diary are found. She rests there — cocooned and
  protected by beds of roses and thorns, weeping peacefully in eternal slumber. This resolves the open question of
  Rose's present-day status (see her Open Threads): she isn't a roaming spirit, she's asleep at the heart of her own
  garden.

**Open flag:** dungeon enemy/difficulty scaling should likely align with these same breakpoints — not yet designed.
