using Infrastructure.GameLogic.Camera;
using Zenject;

namespace Infrastructure.MonoInstallers
{
    public class CameraInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<CameraModel>().AsSingle();
            Container.BindInterfacesAndSelfTo<CameraController>().AsSingle();
        }
    }
}