using Infrastructure.GameLogic.Input;
using Zenject;

namespace Infrastructure.MonoInstallers
{
    public class InputInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<InputModel>().AsSingle();
            Container.BindInterfacesAndSelfTo<InputController>().AsSingle();
        }
    }
}