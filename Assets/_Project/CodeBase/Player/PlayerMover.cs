using CodeBase.Input;
using UnityEngine;

namespace CodeBase.Player.Movement
{
    public class PlayerMover : MonoBehaviour, IDisabled
    {
        [SerializeField] private PlayerInput _playerInput;
        [SerializeField] private CharacterController _characterController;
        [SerializeField] private float _movementSpeed;
        [SerializeField] private Camera _camera;

        private void Update()
        {
            Move();
        }

        public void Disable()
        {
            enabled = false;
        }

        public void Enable()
        {
            enabled = true;
        }

        private void Move()
        {
            Vector3 movementVector = Vector3.zero;

            if (_playerInput.Axis.sqrMagnitude > Constants.Epsilon)
            {
                movementVector = _camera.transform.TransformDirection(_playerInput.Axis);
                movementVector.y = 0;
                movementVector.Normalize();

                transform.forward = movementVector;
            }

            movementVector += Physics.gravity;

            _characterController.Move(_movementSpeed * Time.deltaTime * movementVector);
        }
    }
}

