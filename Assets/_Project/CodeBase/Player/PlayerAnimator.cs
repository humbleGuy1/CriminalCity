using UnityEngine;

namespace CodeBase.Player.Animation
{
    public class PlayerAnimator : MonoBehaviour, IDisabled
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private CharacterController _characterController;

        private const string Velocity = "Velocity";

        private readonly int _velocityHash = Animator.StringToHash(Velocity);

        private void Update()
        {
            _animator.SetFloat(_velocityHash, _characterController.velocity.magnitude);
        }

        public void Enable()
        {
            enabled = true;
        }

        public void Disable()
        {
            enabled = false;
        }

        private void TriggerAnimation(int stateHash)
        {
            _animator.SetTrigger(stateHash);
        }
    }
}

