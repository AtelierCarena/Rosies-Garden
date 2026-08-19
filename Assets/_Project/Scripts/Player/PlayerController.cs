using UnityEngine;
using UnityEngine.InputSystem;

namespace RosiesGarden.Player
{
    /// <summary>
    /// True top-down 8-directional movement (Stardew Valley / Sun Haven style — no camera tilt,
    /// no pseudo-3D depth). Reads from the new Input System via PlayerInput's "Move" action.
    /// </summary>
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 4.5f;

        private Rigidbody2D _rb;
        private Vector2 _moveInput;
        private Animator _animator;

        private static readonly int MoveX = Animator.StringToHash("MoveX");
        private static readonly int MoveY = Animator.StringToHash("MoveY");
        private static readonly int Speed = Animator.StringToHash("Speed");

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            _rb.gravityScale = 0f;
            _rb.freezeRotation = true;
            _animator = GetComponent<Animator>();
        }

        // Hooked up via PlayerInput (Send Messages) to an action named "Move" (Vector2).
        public void OnMove(InputValue value)
        {
            _moveInput = value.Get<Vector2>();
        }

        private void FixedUpdate()
        {
            _rb.MovePosition(_rb.position + _moveInput.normalized * moveSpeed * Time.fixedDeltaTime);
        }

        private void Update()
        {
            if (_animator == null) return;

            if (_moveInput.sqrMagnitude > 0.01f)
            {
                _animator.SetFloat(MoveX, _moveInput.x);
                _animator.SetFloat(MoveY, _moveInput.y);
            }

            _animator.SetFloat(Speed, _moveInput.sqrMagnitude);
        }
    }
}
