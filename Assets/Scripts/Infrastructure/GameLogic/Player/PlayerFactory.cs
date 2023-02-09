using UnityEngine;
using Zenject;

namespace Infrastructure.GameLogic.Player
{
    public class PlayerFactory : IFactory<GameObject>
    {
        [Inject] private DiContainer _diContainer;
        private GameObject _playerPrefab;

        public PlayerFactory(GameObject playerPrefab)
        {
            _playerPrefab = playerPrefab;
            Debug.Log("Player prefab name - " + _playerPrefab.name);
        }
        
        public GameObject Create()
        {
            var playerInstance = GameObject.Instantiate(_playerPrefab, Vector3.zero, Quaternion.identity);
            _diContainer.InjectGameObject(playerInstance);

            return playerInstance;
        }
    }
}