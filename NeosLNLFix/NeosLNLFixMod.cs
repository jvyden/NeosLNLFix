using HarmonyLib;
using NeosModLoader;

namespace NeosLNLFix;

public class NeosLNLFixMod : NeosMod
{
    static NeosLNLFixMod()
    {
        Harmony.DEBUG = true;
    }
    
    public override string Name => "NeosLNLFix";
    public override string Author => "jvyden";
    public override string Version => "1.0.0";
    public override string Link => "https://github.com/jvyden/NeosLNLFix";

    public const string EndpointDomain = "uswest1.resonite.com";
    public const int MatchmakerPort = 3000;
    public const int RelayPort = 3001;

    public override void OnEngineInit()
    {
        Harmony harmony = new(Name);
        harmony.PatchAll();
    }
}