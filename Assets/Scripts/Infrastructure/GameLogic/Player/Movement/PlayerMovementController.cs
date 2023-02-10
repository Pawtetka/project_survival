using System;
using System.Security.Cryptography.X509Certificates;
using Infrastructure.GameLogic.Camera;
using Infrastructure.GameLogic.Input;
using UnityEngine;
using Zenject;

namespace Infrastructure.GameLogic.Player.Movement
{
    public class PlayerMovementController : ITickable
    {
        private InputModel _inputModel;
        private CameraController _cameraController;
        private PlayerMovementModel _playerMovementModel;
        private Rigidbody2D _rigidbody2D;

        private UnityEngine.Camera _mainCamera;
        private Vector3 _moveOffset;

        public PlayerMovementController(InputModel inputModel, CameraController cameraController,
                                        PlayerMovementModel playerMovementModel, Rigidbody2D rigidbody2D)
        {
            _inputModel = inputModel;
            _cameraController = cameraController;
            _playerMovementModel = playerMovementModel;
            _rigidbody2D = rigidbody2D;

            _moveOffset = Vector3.zero;
        }

        public void Tick()
        {
            HandleInput();
        }
        
        private void Move(Vector2 direction)
        {
            _moveOffset = new Vector3(direction.x, direction.y) * (_playerMovementModel.Speed * Time.deltaTime);
            _rigidbody2D.MovePosition(_rigidbody2D.transform.position + _moveOffset);
        }

        private void Rotate()
        {
            if(_mainCamera == null) _mainCamera = _cameraController.CameraModel.GetMainCamera();
            
            Vector2 mousePosition = _mainCamera.ScreenToWorldPoint(UnityEngine.Input.mousePosition);

            float lookDirection = mousePosition.x - _rigidbody2D.position.x;
            float rotation = lookDirection >= 0 ? 0 : 180f;
            
            _rigidbody2D.transform.rotation = Quaternion.Euler(0, rotation, 0);
        }

        private void HandleInput()
        {
            var direction = new Vector2(_inputModel.HorizontalAxisInput, _inputModel.VerticalAxisInput).normalized;
            Move(direction);
            Rotate();
        }
    }
}