# NeosLNLFix

A quick'n'dirty fix for Neos to use Resonite's LNL servers, letting you play with friends on the [Neos Archive Client](https://neosarchive.org/).

Do note that playing with others isn't quite recommended as:
- Neos is never going to be updated to fix vulnerabilities
- The Neos Archive team doesn't provide any moderation

For those reasons you should only play with people you trust.

## How do I get my LNL url?

You can get your LNL url by inspecting a session orb. From the worlds tab, click your session, expand the modal, and then click 'Get Session Orb'.

Inspect the spawned orb, and then you can find the session URLs listed.

In some cases only the Steam URL will work. No clue why, but for that reason make sure you're playing on Steam.

## How do I join my friend?

There's a couple methods for this, but I personally create an empty object, attach a WorldOrb component and then use the LNL url as the world URL.

You can also use the JoinWorld logix node for this.