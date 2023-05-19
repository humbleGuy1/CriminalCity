using UnityEngine;

namespace CodeBase
{
    public class PlayerFollower : MonoBehaviour
    {
        [SerializeField] private Transform _player;
        [SerializeField] private float _rotationAngleX;
        [SerializeField] private float _rotationAngleY;
        [SerializeField] private float _distance;
        [SerializeField] private float _offsetY;

        private void LateUpdate()
        {
            Quaternion rotation = Quaternion.Euler(_rotationAngleX, _rotationAngleY, 0);

            Vector3 followingPosition = _player.position;
            followingPosition.y += _offsetY;

            Vector3 position = rotation * new Vector3(0, 0, -_distance) + followingPosition;

            transform.rotation = rotation;
            transform.position = position;
        }
    }
}

