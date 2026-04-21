using UnityEngine;
namespace CharacterController
{
    public class PlayerManager : MonoBehaviour
    {
        public PlayerAction _playerAction;
        private Rigidbody2D _rigidbody2D;
        private Vector2 _playerMove = new Vector2();

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _playerAction = new PlayerAction();
        }
        private void OnEnable()
        {
            _playerAction.Enable();
        }
        private void OnDisable()
        {
            _playerAction.Disable();
        }
        private void FixedUpdate()
        {
            _playerMove = _playerAction.Player.Move_Key.ReadValue<Vector2>();
        }
        public void PlayerMove()
        {
            _rigidbody2D.linearVelocity = _playerMove;
        }
        public Vector2 GetPlayerMove()
        {
            return _playerMove;
        }
    }
}