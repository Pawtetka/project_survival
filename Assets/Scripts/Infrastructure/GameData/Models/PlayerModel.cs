using System;
using UnityEngine;

namespace Infrastructure.GameLogic.Models
{
    [Serializable]
    public class PlayerModel
    {
        public string PlayerName { get; private set; }
        public int Coins { get; private set; }
    }
}