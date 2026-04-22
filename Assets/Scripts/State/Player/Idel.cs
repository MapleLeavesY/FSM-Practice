
using UnityEngine;

namespace PlayerState
{
    public class Idel : State
    {
        public Idel(StateManager stateManager, Factory factory) 
            : base(stateManager, factory) 
        {}
        public override void Enter()
        {
            Debug.Log("Enter Idle");
        }
        public override void Update()
        {
            if( _ctx.moveManager.GetPlayerLeft() ||
                _ctx.moveManager.GetPlayerRight() ||
                _ctx.moveManager.GetPlayerUp())
            {
                _currentParentState.SwitchSubState(_factory.GetRun());
            }
        }
        public override void Exit()
        {
            Debug.Log("Exit Idle");
        }
    }
}