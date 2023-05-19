using CodeBase.Input;
using CodeBase.Player.Animation;
using CodeBase.Player.Movement;
using UnityEngine;

namespace CodeBase.Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerInput _playerInput;
        [SerializeField] private PlayerMover _playerMover;
        [SerializeField] private PlayerAnimator _playerAnimator;

        public PlayerInput PlayerInput => _playerInput;
        public PlayerMover PlayerMover => _playerMover;
        public PlayerAnimator PlayerAnimator => _playerAnimator;
    }
}

