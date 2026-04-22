
using UnityEngine;
namespace PlayerState
{
    public class Run : State
    {
        public Run(StateManager stateManager, Factory factory) 
            : base(stateManager, factory) 
        {}

        public override void Enter()
        {
            Debug.Log("Enter Run");
        }
        public override void Update()
        {
            if( !(_ctx.moveManager.GetPlayerLeft() ||
                _ctx.moveManager.GetPlayerRight() ||
                _ctx.moveManager.GetPlayerUp()))
            {
                _currentParentState.SwitchSubState(_factory.GetIdle());
            }
            _ctx.moveManager.LetMove();
        }
        public override void Exit()
        {
            Debug.Log("Exit Run");
        }
    }
}