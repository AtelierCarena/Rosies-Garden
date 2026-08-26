# Rosie's Garden — Art Direction Handoff Package

This document is a self-contained brief for an art-generation AI/tool (or a human illustrator) to produce character and environment art for **Rosie's Garden**, a video game currently in early concept/direction stage. It consolidates a reference-gathering session with the project owner. Everything here is **draft direction, not a locked spec** — flagged open questions are called out explicitly.

Paired with this file: a `references/` folder of image files, organized into subfolders that match the section names below. If you're an AI/tool being fed this handoff, look at the images in each referenced subfolder alongside the text — the text alone under-specifies the visual target.

---

## 1. Overall mood: "Gloomy Coquette"

The tone sits between cutesy-coquette (soft pinks, bows, lace, ruffles) and gothic/moody (black accents, wilted or shadowed florals, dim mystical lighting). **Do not render this as purely sweet pastel.** When in doubt, cut sweetness with black, deep plum/maroon, and low ambient/candlelit lighting rather than bright even lighting.

Keywords: mystical, romantic, a little melancholy, ornate, floral-but-slightly-decayed, candlelit.

References: `references/worldbuilding-ui/`, `references/fashion-coquette-goth/`

---

## 2. Two separate art tiers — do not blend them

### Tier A — Pixel art (overworld sprites, UI chrome, environment, buildings, objects)
Stardew-Valley-style top-down/three-quarter pixel art, but with **more painterly gradient shading** than vanilla Stardew's flat-block pixels — see the stone-angel-statue image in the mystical-pixelart folder as the shading benchmark.

Used for: character overworld sprites, buildings, farm/town map tiles, animals/critters, furniture, decorative objects, HUD elements (hearts, hotbar, dialogue box borders).

Palette: soft creams, dusty pinks, sage green, deep brown/maroon roofing, black outline linework.

Add mystical lighting: glowing particles, soft god-rays, floating flower petals, faint sparkle/glimmer overlays.

References: `references/mystical-pixelart/`, `references/worldbuilding-ui/`

### Tier B — Painterly close-up portraits (dialogue box art, diary/profile screens)
Used only for: the character portrait shown during dialogue interactions, and the character's profile/bio page in the player's in-game diary.

Style: soft airbrushed/pastel-textured rendering, glittery/sparkle highlight detail in the eyes, loose expressive linework, a shallow/limited color range per piece (often near-monochrome plus one accent color — e.g. pink+white, or black+pink).

This is NOT pixel art. It reads closer to a stylized illustrated bust/portrait.

References: `references/portrait-closeup-style/`

---

## 3. Character proportions / scale system

Reference: `references/sizing-proportions/`

Two additional references were shown during the session but could not be saved as files (described here for completeness):
- A K-pop-style "등신" (head-count) deformation chart showing 7등신 (realistic proportion) down through 3~4등신, 2등신, and "2등신 이하" (chibi), each annotated with intended use-case (normal art vs. small merch-style SD vs. tiny sticker-style chibi).
- A blank RPG-style character bio/personality template (sections: Background, Physique, Mental & Personality, Interpersonal, Morals & Beliefs, Skills, Interests & Ambition) — this is a **content/writing template**, not a visual style reference; it shows the level of depth expected in each character's written bio.

Direction: characters likely need multiple render scales depending on UI context, following an SD-chibi convention:
- Full-size normal proportion — main portraits / cutscenes (Tier B)
- "Mini" SD (~3-4 heads tall) — expressive overworld sprites
- "Teeny" SD (~2 heads tall) — smaller UI use (party list icons, etc.)
- "Chibi"/"Wiwi" (~1-1.5 heads tall) — smallest icon-scale use (menu tokens, achievement icons)

**OPEN QUESTION:** which scale tier(s) are actually needed for which UI surface in this game — not yet confirmed with the owner.

---

## 4. Body-type diversity

Three body-type comparison charts were shown during the session but could not be saved as files (described here):
1. A 5-silhouette chart labeled **Stick / Hourglass / Wide Top / Blocky / Bottom Heavy**.
2. A 6-figure chart labeled **Pear / Slender / Apple / Leggy / Rectangle / Athletic**.
3. A chart showing 5 painted body types plus their grayscale sculpt/base-mesh equivalents underneath.

Direction: **body types should vary per character, chosen deliberately**, based on:
- **Job/occupation** — e.g. a blacksmith reads more athletic/blocky; a scholar might be slender.
- **Species** — fae/elf vs. human vs. anthro/otter-kin should read as visually distinct builds.
- **Personality** — a soft/nurturing character vs. a severe/commanding one should differ physically.

**OPEN QUESTION:** a per-character body-type assignment table has not yet been built — needs the full roster's jobs/personalities finalized first.

---

## 5. UI / HUD direction

Reference: `references/worldbuilding-ui/`

- Hearts/HP shown as a decorative row (floral, bow motifs) rather than plain icons.
- Inventory/menu frames with ornate corner flourishes (bows, roses). Pink-on-dark-plum reads better for the "gloomy coquette" mood than pink-on-white.
- Dialogue box: parchment/cream box with a rose-vine border, character portrait bust framed to one side (see the two-portrait NPC dialogue screenshot in this folder).

---

## 6. Fashion / costume language

Reference: `references/fashion-coquette-goth/`

Recurring motifs to draw from: satin ribbon lace-up detailing, bows as accents (shoes, socks, collars — usually a contrasting color, e.g. black bow on a white sock), platform heels/boots, lace-trimmed hosiery, corset/underbust silhouettes, witch-hat silhouettes softened (pastel felt, ribbon trim), fishnet layered under sweetness rather than worn alone.

Treat this as a costume **vocabulary**, not a mandate — adapt to each character's role. A farmhand wouldn't wear platform heels daily, but might own a "festival outfit" drawing on this language.

---

## 7. Environment / world-building direction

Reference: `references/worldbuilding-ui/`

- Town/farm layout: cottagecore-adjacent, Stardew-style top-down map, dense with flowering trees (cherry blossom, wisteria), cobblestone/brick paths.
- Interiors: floral wallpaper, rose motifs, warm lamp lighting, plush pink furniture — but include at least one dark/moody interior (a witch's tower, an overgrown greenhouse, a graveyard garden) to keep the "gloomy" half of the mood present, rather than making every interior uniformly sweet.
- Building exteriors: European cottage/Victorian silhouettes (turrets, dark wood-shingle roofs, climbing roses) rather than log-cabin Americana.

---

## 8. Character roster (visual placeholders only — personalities/jobs not yet briefed)

All five images below were generated via a third-party "picrew"-style avatar maker as rough placeholders, not final designs, and could not be saved as files for this handoff — described in full detail here instead. **Species/job/personality for each is not yet defined** — needed before body-type (§4) can be assigned.

### Nix
Fae/fairy character. Butterfly-style wings (lilac/purple, veined). Red hair styled in space-buns combined with long pale-blonde/white hair on one side (two-tone split). Sage-green head wrap with a small bow. Freckles, dark red/pink eyes. Dark maroon dress, gothic-style choker and pendant necklace. Shown against a moody dark-forest backdrop — reads as the most literal "gloomy coquette" character of the set. Use as a strong anchor reference for the target mood.

### Olivier
Elf (long pointed ears). Messy dark auburn/brown wavy hair with a center part. Round wire-frame glasses. Amber/gold eyes. Light stubble, a small scar/mark near one eye, freckles. Wears a black button-up shirt with a tie. Reads scholarly and reserved — a deliberate contrast to Nix's fae whimsy.

### Silas
**Placeholder is wrong and needs correction:** the generator used had no otter option, so the placeholder shows cat-like ears/nose — the actual character should have otter features instead (rounder ears, whiskers, an otter-shaped nose/snout, and per the body-type rule in §4, likely a stockier/more athletic build appropriate to an otter-kin). Otherwise keep: warm brown wavy hair, blue eyes, rectangular glasses, tan skin, black turtleneck.

### Bella
Human. Voluminous curly brown hair with two-tone bleached/blonde box braids framing the face. Small dark/white horn-shaped hair clips or bows. Rectangular glasses. Gray-blue eyes, tan skin. Layered necklaces with a pendant charm. Oversized graphic tee / off-shoulder top. Alt/grunge aesthetic — a deliberate contrast to the more "fantasy-fancy" members of the cast.

### Leonair
Elf (long pointed ears), mage-coded. Tan skin, pale blonde hair, violet/purple sparkly eyes, rectangular glasses. Scruffy beard with a small braided chin-tuft. Wide dark navy witch/wizard hat, green-and-navy jacket. **Placeholder under-delivers on magic:** the final design needs noticeably more ornate hat detailing, glowing/arcane accents, and a richer robe/costume treatment than the flat placeholder shows.

---

## 9. Recommended execution order

1. Confirm species/job/personality for each roster member — this decides body-type per §4.
2. Produce corrected concept art for **Silas** (otter features) and **Leonair** (more magical costume) first — both are explicitly flagged as wrong/incomplete.
3. Decide which proportion/scale tiers (§3) are actually needed in-game before full sprite production, since it multiplies the art needed per character.
4. Pick **one character** and produce both a Tier A (pixel-art sprite) and Tier B (painterly portrait) mockup to validate the whole direction before scaling to the rest of the roster.

---

## 10. Reference image index

| Folder | Count | Content |
|---|---|---|
| `references/sizing-proportions/` | 1 | SD/chibi proportion ladder chart |
| `references/mystical-pixelart/` | 7 | Tier A pixel-art style target — painterly shading, mystical lighting, statue/flower imagery |
| `references/fashion-coquette-goth/` | 16 | Costume/fashion motif pulls (ribbons, bows, lace, platforms, witchy fits) |
| `references/portrait-closeup-style/` | 6 | Tier B painterly close-up portrait style target |
| `references/worldbuilding-ui/` | 16 | HUD, menus, maps, interiors, building exteriors |

Total: 46 image files included in this package.
