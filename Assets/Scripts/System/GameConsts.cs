using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameConsts
{
    public enum GameState
    {
        inLobby,
        inGame,
        inUI,
    }

    public static class ConstLayerMask
    {
        public static readonly LayerMask playerMask = LayerMask.GetMask("Player");
        public static readonly LayerMask objMask = LayerMask.GetMask("Object");
    }

    public static class AudioSourceName
    {
        public static readonly string LobbyBGM = "LobbyBGM";
        public static readonly string Level1BGM = "Level1BGM";
    }

    public static class SceneName
    {
        public static readonly string LobbyScene = "Lobby";
        public static readonly string Level1Scene = "InGame";
    }
}
