using UnityEngine;
using Zenject;

namespace Infrastructure.MonoInstallers
{
    public class BootstrapInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Debug.Log("Hello world");
        }
    }
}