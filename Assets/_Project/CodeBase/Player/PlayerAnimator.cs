using CodeBase.Input;
using UnityEngine;

namespace CodeBase.Player.Animation
{
    public class PlayerAnimator : MonoBehaviour, IDisabled
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private CharacterController _characterController;
        [SerializeField] private PlayerInput _plyerInput;

        private const string Velocity = "Velocity";
        private const string Jump = "Jump";

        private readonly int _velocityHash = Animator.StringToHash(Velocity);
        private readonly int _jumpHash = Animator.StringToHash(Jump);

        private void Update()
        {
            _animator.SetFloat(_velocityHash, _characterController.velocity.magnitude);

            if (_plyerInput.IsJumpPressed)
                PlayAnimation(_jumpHash);
        }

        public void Enable() => enabled = true;

        public void Disable() => enabled = false;

        private void PlayAnimation(int stateHash) => _animator.Play(stateHash);
    }
}

