using System;
using UnityEngine;

namespace Infrastructure.GameLogic.Models
{
    [Serializable]
    public class PlayerModel
    {
        public string PlayerName { get; set; }
        public int Coins { get; set; }

        public PlayerModel()
        {
            PlayerName = "default";
            Coins = 100;
        }
    }
}