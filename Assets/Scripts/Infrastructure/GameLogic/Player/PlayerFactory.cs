using UnityEngine;
using Zenject;

namespace Infrastructure.GameLogic.Player
{
    public class PlayerFactory : IFactory<GameObject>
    {
        [Inject] private DiContainer _diContainer;
        private readonly GameObject _playerPrefab;

        public PlayerFactory(GameObject playerPrefab)
        {
            _playerPrefab = playerPrefab;
        }
        
        public GameObject Create()
        {
            var playerInstance = _diContainer.InstantiatePrefab(_playerPrefab);
            return playerInstance;
        }
    }
}