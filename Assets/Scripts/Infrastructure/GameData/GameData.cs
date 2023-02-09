using System;
using Infrastructure.GameLogic.Models;

namespace Infrastructure.GameData
{
    [Serializable]
    public class GameData
    {
        public PlayerModel playerData { get; set; }

        public GameData()
        {
            playerData = new PlayerModel();
        }
    }
}