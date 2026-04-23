using UnityEngine;
namespace PlayerState
{
    public class IsGround : State
    {
        public IsGround(StateManager stateManager, Factory factory)
            : base(stateManager, factory)
        {}
        public override void Enter()
        {
            Debug.Log("Enter IsGround");
            SwitchSubState(_factory.GetIdle());

        }
        public override void Update()
        {
            if (!_ctx.moveManager.ISGrounded())
        {
            _ctx.SwitchState(_factory.GetIsAir());
            return;
        }
            SubUpdate();
        }
        public override void Exit()
        {
            Debug.Log("Exit IsGround");
        }
    }
}