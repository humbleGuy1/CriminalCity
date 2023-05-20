using CodeBase.Input;
using CodeBase.Player.Animation;
using CodeBase.Player.Health;
using CodeBase.Player.Movement;
using UnityEngine;

namespace CodeBase.Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField, Range(0, 100)] private int _startHealthValue;
        [Space]
        [SerializeField] private PlayerInput _playerInput;
        [SerializeField] private PlayerMover _playerMover;
        [SerializeField] private PlayerAnimator _playerAnimator;

        private PlayerHealth _playerHealth;

        public PlayerInput PlayerInput => _playerInput;
        public PlayerMover PlayerMover => _playerMover;
        public PlayerAnimator PlayerAnimator => _playerAnimator;
        public PlayerHealth Health => _playerHealth;

        private void Awake()
        {
            _playerHealth = new PlayerHealth(_startHealthValue);
        }

        private void OnEnable()
        {
            _playerHealth.ReachedZero += Die;
        }

        private void OnDisable()
        {
            _playerHealth.ReachedZero -= Die;
        }

        private void Die()
        {
            print("Die");
        }
    }
}

