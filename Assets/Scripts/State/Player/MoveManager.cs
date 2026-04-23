using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveManager : MonoBehaviour
{
    private PlayerAction _playAction;
    private Rigidbody2D _rigidbody2D;
    private const float MOVE_NORMAL = 8f;
    private const float JUMP_NORMAL = 12f;
    private const float CHECK_RADIUS_NORMAL = .2f;  
    [Header("MoveMent")]
    public float moveSpeed = MOVE_NORMAL;
    public float jumpForce = JUMP_NORMAL;
    [Header("Ground Check")]
    public Transform groundCheck;
    public float checkRadius = CHECK_RADIUS_NORMAL;
    public LayerMask groundLayer;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _playAction = new PlayerAction();
    }
    private void OnEnable() => _playAction.Enable();
    private void OnDisable() => _playAction.Disable();

    public float GetMoveInput()
    {
        float left = _playAction.Player.MoveLeft.IsPressed() ? -1 : 0;
        float right = _playAction.Player.MoveRight.IsPressed() ? 1 : 0;
        return left + right;
    }
    public bool GetJumpPressed()
    {
        return _playAction.Player.MoveUP.WasPressedThisFrame();
    }
    
    public void Move()
    {
        float x = GetMoveInput();
        _rigidbody2D.linearVelocity = new Vector2(x * moveSpeed, _rigidbody2D.linearVelocityY);
    }
    public void Jump()
    {
        _rigidbody2D.linearVelocity = new Vector2(_rigidbody2D.linearVelocityX, jumpForce);
    }

    public float GetVelocityY()
    {
        return _rigidbody2D.linearVelocityY;
    }
    public bool ISGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer);
    }
}
