# Expando Zone

Expando Zone adds a separate stockpile tool that automatically fills the available space in a room.

## Use the Expando Zone tool

1. Open **Architect > Zone > Expando Zone**. Choose this separate tool when you want automatic expansion.
2. Place a small seed zone, such as a single cell, inside the room you want to use for storage.
3. Unpause and allow the game to run briefly. With **Auto-Expand** enabled (the default), the zone fills eligible empty cells in that room on its next periodic update.
4. Select the zone to change its storage settings or toggle **Auto-Expand**.

Existing normal stockpiles keep their cells and settings. Automatic expansion skips cells already occupied by another zone, as well as fogged cells and objects that cannot overlap zones. You can keep a normal stockpile beside an Expando Zone in the same room.

## Keep a manually chosen shape

Pause the game, create or select an Expando Zone, and turn **Auto-Expand** off before resuming. You can then manually add or remove zone cells using the usual zone tools without automatic room fill restoring them. Turning the toggle off does not remove cells already added. Turn it back on when you want automatic expansion again, or use a normal stockpile for storage that never needs automatic expansion.

## When expansion happens

Expansion is periodic and requires the game to be running. The mod checks the currently viewed map and uses the room containing the zone's first cell. Place the seed wholly inside the intended room. Rooms classified by the game as huge are skipped, so do not rely on automatic filling of open outdoor spaces. Expansion adds cells; it does not automatically shrink the zone.

## Gameplay image pending

A real in-game screenshot will be added after coordinator testing. Suggested capture: a small enclosed room with a selected Expando Zone filling the available floor, a separate normal stockpile preserved in one corner, the **Auto-Expand** toggle visible, and **Architect > Zone** open with the **Expando Zone** tool identifiable. If the UI cannot show all of this clearly in one shot, use a before/after pair showing the one-cell seed and filled result.

Suggested caption: “Choose Architect > Zone > Expando Zone, place a small seed, and unpause to fill the room. Existing stockpiles stay in place; switch Auto-Expand off for a manual shape.”

See [the proposed Workshop description](docs/workshop-description.txt) for publication-ready text. Publication and the gameplay image are pending coordinator review.
