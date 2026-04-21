using Unity.VisualScripting;
using UnityEngine;

namespace PlayerState
{
    public class Idle : BaseState
    {
        public Idle(StateManager stateManager, Factory factory) : base(stateManager, factory)
        {}
        public override void StateEnter()
        {
            Debug.Log("welcome Enter IdleState!");
        }
        public override void StateUpdate()
        {
            if(_stateManager._playerManager.GetPlayerMove() != Vector2.zero)
                _stateManager.SwitchState(_factory.GetRunState());
        }
        public override void StateExit()
        {
            Debug.Log("welcome Exit IdleState!");
        }
    }
}