using UnityEngine;

namespace CodeBase.Input
{
    public interface IInput
    {
        public Vector2 Axis { get; }

        public bool IsJumpPressed { get; }
    }
}