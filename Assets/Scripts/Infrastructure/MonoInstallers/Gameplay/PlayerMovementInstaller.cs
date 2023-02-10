using Infrastructure.GameLogic.Player.Movement;
using UnityEngine;
using Zenject;

namespace Infrastructure.MonoInstallers
{
    public class PlayerMovementInstaller : MonoInstaller
    {
        [SerializeField] private Rigidbody2D _rigidbody2D; 
        public override void InstallBindings()
        {
            Container.Bind<Rigidbody2D>().FromComponentOn(_rigidbody2D.gameObject).AsSingle();

            Container.Bind<PlayerMovementModel>().AsSingle();
            Container.BindInterfacesAndSelfTo<PlayerMovementController>().AsSingle().NonLazy();
        }
    }
}