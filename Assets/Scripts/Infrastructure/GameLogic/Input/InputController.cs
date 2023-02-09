using System;
using Infrastructure.GameLogic.Camera;
using UnityEngine;
using Zenject;

namespace Infrastructure.GameLogic.Input
{
    public class InputController : IInitializable, IDisposable
    {
        public InputModel InputModel { get; private set; }
        
        private CameraController _cameraController;
        
        public InputController(InputModel inputModel, CameraController cameraController)
        {
            InputModel = inputModel;
            _cameraController = cameraController;
        }
        
        public void Initialize()
        {
            InputModel.OnGetMousePosition += HandleOnGetMousePosition;
            InputModel.OnGetHorizontalAxisInput += HandleOnGetHorizontalAxisInput;
            InputModel.OnGetVerticalAxisInput += HandleOnGetVerticalAxisInput;
        }

        public void Dispose()
        {
            InputModel.OnGetMousePosition -= HandleOnGetMousePosition;
            InputModel.OnGetHorizontalAxisInput -= HandleOnGetHorizontalAxisInput;
            InputModel.OnGetVerticalAxisInput -= HandleOnGetVerticalAxisInput;
        }
        
        private Vector3 HandleOnGetMousePosition()
        {
            var camera = _cameraController.CameraModel.GetMainCamera();
            return camera.ScreenToWorldPoint(UnityEngine.Input.mousePosition);
        }

        private float HandleOnGetHorizontalAxisInput() => UnityEngine.Input.GetAxis("Horizontal");
        private float HandleOnGetVerticalAxisInput() => UnityEngine.Input.GetAxis("Vertical");
    }
}