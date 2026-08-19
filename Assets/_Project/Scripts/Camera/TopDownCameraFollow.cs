using UnityEngine;

namespace RosiesGarden.CameraSystem
{
    /// <summary>
    /// Straight-down orthographic follow camera for the main world — Stardew Valley / Sun Haven
    /// style. No tilt, no depth billboarding (that DST-style treatment is retired; see
    /// docs/design/01-technical-architecture.md, 2.4). Smoothly tracks a target and can be
    /// clamped to world bounds once level geometry exists.
    /// </summary>
    public class TopDownCameraFollow : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private float followSmoothTime = 0.12f;
        [SerializeField] private bool clampToBounds;
        [SerializeField] private Vector2 minBounds;
        [SerializeField] private Vector2 maxBounds;

        private Vector3 _velocity;
        private Camera _cam;

        private void Awake()
        {
            _cam = GetComponent<Camera>();
            if (_cam != null)
            {
                _cam.orthographic = true;
            }
        }

        public void SetTarget(Transform newTarget) => target = newTarget;

        private void LateUpdate()
        {
            if (target == null) return;

            Vector3 desired = new Vector3(target.position.x, target.position.y, transform.position.z);

            if (clampToBounds && _cam != null)
            {
                float halfHeight = _cam.orthographicSize;
                float halfWidth = halfHeight * _cam.aspect;

                desired.x = Mathf.Clamp(desired.x, minBounds.x + halfWidth, maxBounds.x - halfWidth);
                desired.y = Mathf.Clamp(desired.y, minBounds.y + halfHeight, maxBounds.y - halfHeight);
            }

            transform.position = Vector3.SmoothDamp(transform.position, desired, ref _velocity, followSmoothTime);
        }
    }
}
