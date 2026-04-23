
using Unity.VisualScripting;
using UnityEngine;

namespace PlayerState
{
    public class Idel : State
    {
        public Idel(StateManager stateManager, Factory factory) 
            : base(stateManager, factory) {}

        public override void Enter()
        {
            Debug.Log("Enter Idle");
        }
        public override void Update()
        {
            if(_ctx.moveManager.GetMoveInput() != 0)
            {
                _currentParentState.SwitchSubState(_factory.GetRun());
            }
            if(_ctx.moveManager.GetJumpPressed())
            {
                _ctx.SwitchState(_factory.GetIsAir());
                _ctx.moveManager.Jump();
            }
        }
        public override void Exit()
        {
            Debug.Log("Exit Idle");
        }
    }
}