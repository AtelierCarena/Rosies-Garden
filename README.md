# Rosie's Garden

An adorable, coquette-styled top-down adventure and building game blending cozy farming/social-sim systems with
crafting depth, dungeon-crawling stakes, and shop-keeping economics. Inspired by Stardew Valley, Minecraft, Sun
Haven, Moonlighter, and Don't Starve Together.

## Design Documentation
The full design is written up in [`docs/design/`](docs/design/README.md), split by system (skill trees, NPC
relationships, companions, items, combat classes, dungeons, etc.). Start there before touching gameplay code — it's
the living source of truth for what's being built and why.

## Project Structure
- `docs/design/` — game design documentation
- `Assets/_Project/` — game-specific Unity assets (Scripts, Scenes, Prefabs, Art, Audio)
- `Packages/manifest.json` — Unity package dependencies (URP, Tilemap, Input System, Netcode for GameObjects)

## Engine
Unity (2022 LTS or newer recommended), Universal Render Pipeline, 2D Tilemap workflow. See
[`docs/design/01-technical-architecture.md`](docs/design/01-technical-architecture.md) for the full rationale and the
solo/split-screen/online architecture split.

Opening this repo in Unity Hub for the first time will generate `Library/`, `ProjectSettings/`, and other local
editor-managed folders — those are gitignored and regenerate automatically, so don't worry if they're missing on
clone.
