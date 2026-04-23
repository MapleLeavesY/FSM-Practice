using PlayerState;
using UnityEngine;

public class IsAir : State
{
    public IsAir(StateManager stateManager, Factory factory)
            : base(stateManager, factory)
        {}

    public override void Enter()
    {
        if(_ctx.moveManager.GetVelocityY() > 0)
        {
            SwitchSubState(_factory.GetJump());
        }
        else
        {
            SwitchSubState(_factory.GetFall());
        }
    }
    public override void Update()
    {
        if(_ctx.moveManager.ISGrounded())
        {
            _ctx.SwitchState(_factory.GetIsGround());      
            return;
        }
        SubUpdate();

    }
    public override void Exit()
    {
        Debug.Log("Exit IsAir");
    }
}
