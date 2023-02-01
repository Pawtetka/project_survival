using Infrastructure.GameLogic.Models;
using UnityEngine;
using Zenject;

namespace Infrastructure.MonoInstallers
{
    public class PlayerDataInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<PlayerModel>().AsSingle();
        }
    }
}