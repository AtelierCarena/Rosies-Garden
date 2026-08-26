# Rosie's Garden — Visual Style Guide (v0.1 draft)

Status: **early direction-setting draft**, compiled from a reference dump session with the project owner. Nothing here is final — treat it as the starting point for concept art, not a locked spec. Sizes/values in brackets are placeholders to be confirmed with the art lead.

---

## 1. Overall mood: "Gloomy Coquette"

The intended tone sits between cutesy-coquette (soft pinks, bows, lace, ruffles) and gothic/moody (black accents, wilted or shadowed florals, dim mystical lighting). Reference note from the owner: *"I'd like a little more gloomy coquette vibes"* after seeing purely sweet/pastel worldbuilding references — meaning: **do not let the palette go full saccharine pastel.** Cut sweetness with black, deep plum/maroon, and low ambient light.

Keywords: mystical, romantic, a little melancholy, ornate, floral-but-slightly-decayed, candlelit.

See `references/worldbuilding-ui/` and `references/fashion-coquette-goth/` for the full pull.

---

## 2. Two art tiers

The game uses **two distinct rendering styles** for two different contexts. Do not blend them — each has its own job.

### Tier A — Pixel art (overworld, sprites, UI chrome, environment)
- Stardew-Valley-POV top-down/three-quarter sprites, but with **more painterly shading** than vanilla Stardew — see `references/mystical-pixelart/` (the stone-angel-statue screenshot in particular: soft gradient shading, not flat pixel blocks).
- Used for: character overworld sprites, buildings, farm/town map tiles, animals/critters, furniture, decorative objects, HUD elements (hearts, hotbar, dialogue box borders).
- Palette: soft creams, dusty pinks, sage green, deep brown/maroon roofing, with black outline linework.
- Add "mystical lighting": glowing particles, soft god-rays, floating flower petals, faint sparkle/glimmer overlays — see the angel-statue and glowing-figure references.

### Tier B — Painterly close-up portraits (dialogue UI, diary/profile screens)
- Used specifically for: the character portrait shown during dialogue interactions, and the character's profile/bio page in the player's diary.
- Reference: `references/portrait-closeup-style/` — soft airbrushed/pastel textured rendering, glittery/sparkle detail in the eyes, loose expressive linework, shallow color range per piece (mostly monochrome-plus-one-accent: pink+white, black+pink, etc.)
- This is **not** pixel art — it's a semi-painterly illustrated bust, closer to a stylized portrait than a game sprite.
- I (Claude) can't produce actual paintings — this tier needs a human illustrator or an art-gen tool; this guide documents direction only.

---

## 3. Character proportions / scale system

Reference: `references/sizing-proportions/01-proportion-chart-wiwi-teeny-mini-chibi.jpg`, plus a second (not saved) K-pop-style "등신" deformation chart and a third "7등신 / 3~4등신 / 2등신 / 2등신 이하" reference.

Takeaway: characters may need **multiple render scales** depending on context, following an SD-chibi convention:
- Full-size normal proportion (main portraits / cutscenes)
- "Mini" SD (~3–4 heads tall) for expressive overworld sprites
- "Teeny" SD (~2 heads tall) for smaller UI use (party list icons, etc.)
- "Chibi"/"Wiwi" (~1–1.5 heads tall) for the smallest icon-scale use (menu tokens, achievement icons)

**Action item:** confirm with the owner which scale(s) are actually needed for which UI surface — the reference shows the *concept* of a proportion ladder, not a locked spec for this game.

---

## 4. Body-type diversity

Reference (not saved to repo, described from chat): three body-type comparison charts — one with 5 silhouettes labeled Stick/Hourglass/Wide Top/Blocky/Bottom Heavy, one labeled Pear/Slender/Apple/Leggy/Rectangle/Athletic, and one showing 5 painted body types plus their grayscale base-mesh equivalents.

Direction: **character body types should vary and be chosen deliberately per character**, based on:
- **Job/occupation** (e.g. a blacksmith character reads more athletic/blocky; a scholar might be slender)
- **Species** (fae/elf vs. human vs. anthro/otter-kin should read differently)
- **Personality** (a soft, nurturing character vs. a severe, commanding one)

**Action item:** build a per-character body-type assignment table once the roster and their jobs/personalities are finalized (see `handoff/CHARACTER_ROSTER.md`).

---

## 5. UI / HUD direction

Reference: `references/worldbuilding-ui/` (hotbar/heart HUD, ornate pink inventory menu, pink Stardew-style title/menu chrome).

- Hearts/HP as a decorative row (florals, bows) rather than plain icons.
- Inventory/menu frames with ornate corner flourishes (bows, roses) — pink-on-dark-plum works better for the "gloomy coquette" read than pink-on-white.
- Dialogue box: parchment/cream box with rose-vine border, portrait bust framed on the side (see the Bunny/Lucikiel dialogue screenshot).

---

## 6. Fashion/costume language

Reference: `references/fashion-coquette-goth/`.

Recurring motifs to draw from for costume design: satin ribbon lace-up detailing, bows (as accents on shoes, socks, collars — usually in a contrasting color, e.g. black bow on white sock), platform heels/boots, lace trim on hosiery, corset/underbust silhouettes, witch-hat silhouettes reinterpreted softly (pastel felt, ribbon trim), fishnet layered under sweetness rather than alone.

Use this as a costume vocabulary — not every character needs literal heels/bows; adapt motifs to fit each character's role (see body-type note above — a farmhand character wouldn't wear platform heels day-to-day, but might own a "festival outfit" that draws on this language).

---

## 7. Environment / world-building direction

Reference: `references/worldbuilding-ui/` (town maps, farmhouse map layouts, interior rooms, floral wallpaper swatches, rose-vine trim assets, Minecraft cherry-blossom builds, ACNH island map).

- Town/farm layout: cottagecore-adjacent, Stardew-style top-down map, dense with flowering trees (cherry blossom, wisteria) and cobblestone/brick paths.
- Interiors: floral wallpaper, rose motifs, warm lamp lighting, plush pink furniture — again, pull it toward "gloomy coquette" by adding at least one dark/moody room or area (a witch's tower, a greenhouse-gone-wild, a graveyard garden) rather than making every interior uniformly sweet.
- Building exteriors: European cottage/Victorian silhouettes (turrets, dark wood-shingle roofs, climbing roses) rather than log-cabin Americana.

---

## 8. Open questions for the owner

- [ ] Which scale tier(s) from the proportion chart actually get used, and where?
- [ ] Body-type assignment per confirmed character roster
- [ ] Confirm palette anchor: how "dark" should the gloomy side go (near-black gothic vs. just deep plum/maroon accents)?
- [ ] Is Tier B (painterly portraits) being commissioned from an illustrator, or is there an AI art pipeline in mind?
