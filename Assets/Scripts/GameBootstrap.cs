using UnityEngine;
using Unity.NetCode;

namespace MultiDotz
{
    // Preserve attribute is required to make sure bootstrap
    // is not stripped in il2cpp builds with stripping enabled.
    [UnityEngine.Scripting.Preserve]
    public class GameBootstrap : ClientServerBootstrap
    {
        public override bool Initialize(string defaultWorldName)
        {
            // Enable auto connect.
            AutoConnectPort = 7979;

            // Create default client / server worlds based on:
            // - Playmode Tool's settings in Editor
            // - current build type, if used in a Player
            CreateDefaultClientServerWorlds();

            return true;
        }
    }
}
