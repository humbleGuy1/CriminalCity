using CodeBase.Input;
using DG.Tweening;
using UnityEngine;

namespace CodeBase.Player.Movement
{
    public class PlayerJump : MonoBehaviour, IDisabled
    {
        [SerializeField] private float _range;
        [SerializeField] private float _jumpPower;
        [SerializeField] private float _duration;
        [SerializeField] private AnimationCurve _jumpCurve;
        [Space]
        [SerializeField] private PlayerInput _playerInput;

        private GroundChecker _groundChecker;

        private void Awake() => _groundChecker = new GroundChecker();

        private void Update() => TryJump();

        public void Disable() => enabled = false;

        public void Enable() => enabled = true;

        private void TryJump()
        {
            if (_playerInput.IsJumpPressed == false)
                return;

            if (_groundChecker.CheckFor(gameObject))
            {
                transform.DOJump(transform.forward * _range, _jumpPower, 0, _duration)
                    .SetRelative(true)
                    .SetEase(_jumpCurve);
            }
        }
    }
}

