using Infrastructure.GameData;
using Infrastructure.GameData.Interfaces;
using Infrastructure.GameData.Services;
using Infrastructure.GameLogic.Models;
using UnityEngine;
using Zenject;

namespace Infrastructure.MonoInstallers
{
    public class PlayerDataInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ISerializator>().WithId(Serializators.Binnary).To<BinnarySerializator>().AsSingle();
            Container.BindInterfacesAndSelfTo<GameDataManager>().AsSingle().NonLazy();
        }
    }
}