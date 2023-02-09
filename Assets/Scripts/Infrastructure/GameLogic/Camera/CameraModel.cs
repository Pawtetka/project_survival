using System;

namespace Infrastructure.GameLogic.Camera
{
    public class CameraModel
    {
        public event Func<UnityEngine.Camera> OnGetMainCamera;

        public UnityEngine.Camera GetMainCamera() => OnGetMainCamera?.Invoke();
    }
}