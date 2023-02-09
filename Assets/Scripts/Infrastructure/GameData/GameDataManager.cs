using System.IO;
using Infrastructure.GameData.Interfaces;
using Infrastructure.GameData.Services;
using UnityEngine;
using Zenject;

namespace Infrastructure.GameData
{
    public class GameDataManager : IInitializable
    {
        private GameData _gameData;
        private readonly ISerializator _serializator;
        private readonly string _dataPath;

        public GameData GameData => _gameData;

        public GameDataManager([Inject(Id = Serializators.Binnary)]ISerializator serializator)
        {
            _gameData = new GameData();
            _serializator = serializator;
            _dataPath = @"C:\Users\Pawtetka\Desktop\GameState.dat";
        }
        
        public void Initialize()
        {
            if(!File.Exists(_dataPath)) SaveGameData();
            LoadGameData();
        }

        public void SaveGameData()
        {
            _serializator.SaveData(_dataPath, _gameData);
        }

        private void LoadGameData()
        {
            _gameData = _serializator.LoadData<GameData>(_dataPath);
            Debug.Log(_gameData.playerData.PlayerName + " - " + _gameData.playerData.Coins);
        }
    }
}