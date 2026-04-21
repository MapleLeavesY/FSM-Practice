using UnityEngine;
using PlayerState;
using CharacterController;
using UnityEngine.InputSystem;
namespace PlayerState
{
    public class StateManager : MonoBehaviour
    {
        private Factory _factory;
        private BaseState _currentState;
        public PlayerManager _playerManager;

        public bool IsAir = false;
        public bool IsGround = false;
        private void Awake()
        {
            IsGround = true;
            _playerManager = GetComponent<PlayerManager>();
            _factory = new Factory(this);
            _currentState = _factory.GetIsGroundState();
            _currentState.StateEnter();
        }
        private void Update()
        {
            _currentState.StateUpdate();
        }
        public void SwitchState(BaseState baseState)
        {
            _currentState.StateExit();
            _currentState = baseState;
            _currentState.StateEnter();
        }
    }
}