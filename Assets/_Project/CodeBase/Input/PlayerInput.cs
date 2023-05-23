using UnityEngine;

namespace CodeBase.Input
{
    public class PlayerInput : MonoBehaviour, IInput
    {
        private const string Horizontal = "Horizontal";
        private const string Vertical = "Vertical";

        public Vector2 Axis => new Vector2(SimpleInput.GetAxis(Horizontal), SimpleInput.GetAxis(Vertical));

        public bool IsJumpPressed => SimpleInput.GetKeyDown(KeyCode.Space);
    }
}

