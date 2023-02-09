using Infrastructure.GameLogic.Player;
using UnityEngine;
using Zenject;

namespace Infrastructure.MonoInstallers
{
    public class PlayerFactoryInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _playerPrefab;
        public override void InstallBindings()
        {
            Container.BindInstance(_playerPrefab);
            Container.BindInterfacesAndSelfTo<PlayerFactory>().AsSingle();
        }
    }
}