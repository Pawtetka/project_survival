using System;
using Zenject;

namespace Infrastructure.GameLogic.Camera
{
    public class CameraController : IInitializable, IDisposable
    {
        public CameraModel CameraModel { get; private set; }

        private UnityEngine.Camera _mainCamera;

        public CameraController(CameraModel cameraModel)
        {
            CameraModel = cameraModel;
        }
        
        public void Initialize()
        {
            CameraModel.OnGetMainCamera += HandleGetCameraEvent;
        }

        public void Dispose()
        {
            CameraModel.OnGetMainCamera -= HandleGetCameraEvent;
        }
        
        private UnityEngine.Camera HandleGetCameraEvent()
        {
            return _mainCamera == null ? _mainCamera = UnityEngine.Camera.main : _mainCamera;
        }
    }
}