
using UnityEngine;
namespace PlayerState
{
    public class Run : State
    {
        public Run(StateManager stateManager, Factory factory) 
            : base(stateManager, factory) {}
        public override void Enter()
        {
            Debug.Log("Enter Run");
        }
        public override void Update()
        {
            _ctx.moveManager.Move();

            if(_ctx.moveManager.GetMoveInput() == 0)
            {
                _currentParentState.SwitchSubState(_factory.GetIdle());

            }
            if(_ctx.moveManager.GetJumpPressed())
            {
                _ctx.SwitchState(_factory.GetIsAir());
                _ctx.moveManager.Jump();
            }
        }
        public override void Exit()
        {
            Debug.Log("Exit Run");
        }
    }
}