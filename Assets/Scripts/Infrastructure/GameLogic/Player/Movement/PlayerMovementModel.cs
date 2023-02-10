using UnityEngine;

namespace Infrastructure.GameLogic.Player.Movement
{
    public class PlayerMovementModel
    {
        public float Speed { get; } = 10f;
        public Vector3 Position { get; }
    }
}