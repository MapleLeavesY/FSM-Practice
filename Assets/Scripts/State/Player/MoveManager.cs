using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveManager : MonoBehaviour
{
    private PlayerAction _playAction;
    private Rigidbody2D _rigidbody2D;
    private float SPEED = 10f;
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _playAction = new PlayerAction();
    }
    private void OnEnable()
    {
        _playAction.Enable();
    }
   private void OnDisable()
{
    _playAction.Disable();
}

    
    public void LetMove()
    {
        if(GetPlayerLeft())
        {
            _rigidbody2D.linearVelocityX = -1f * SPEED;
        }
        if(GetPlayerRight())
        {
            _rigidbody2D.linearVelocityX = 1f * SPEED;
        }
        if(GetPlayerUp())
        {
            _rigidbody2D.linearVelocityY = 1f * SPEED;
        }

    }


    public bool GetPlayerLeft()
    {
        return _playAction.Player.MoveLeft.IsPressed();
    }
    public bool GetPlayerRight()
    {
        return _playAction.Player.MoveRight.IsPressed();
    }
    public bool GetPlayerUp()
    {
        return _playAction.Player.MoveUP.IsPressed();
    }
}
