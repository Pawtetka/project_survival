using Infrastructure.GameData;
using UnityEngine;
using Zenject;

namespace Infrastructure.GameLogic.Player
{
    public class PlayerManager : MonoBehaviour
    {
        private GameDataManager _gameDataManager;
        private PlayerFactory _playerFactory;

        [Inject]
        public void Construct(PlayerFactory playerFactory, GameDataManager gameDataManager)
        {
            _gameDataManager = gameDataManager;
            _playerFactory = playerFactory;
        }
        
        public void Awake()
        {
            _playerFactory.Create();
        }
    }
}