using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using HarmonyLib;
using NetX;

namespace NeosLNLFix.Patches;

[SuppressMessage("ReSharper", "InconsistentNaming")]
[HarmonyPatch(typeof(LNL_Implementer))]
public static class LNL_ImplementerPatches
{
    [HarmonyPatch(nameof(LNL_Implementer.MATCHMAKER_EP), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool GetMatchmakerEndpointPrefix(ref IPEndPoint __result)
    {
        __result = new IPEndPoint(Dns.GetHostEntry(NeosLNLFixMod.EndpointDomain).AddressList.First(), NeosLNLFixMod.MatchmakerPort);
        return false;
    }
    
    [HarmonyPatch(nameof(LNL_Implementer.RELAY_EP), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool GetRelayEndpointPrefix(ref IPEndPoint __result)
    {
        __result = new IPEndPoint(Dns.GetHostEntry(NeosLNLFixMod.EndpointDomain).AddressList.First(), NeosLNLFixMod.RelayPort);
        return false;
    }
}