using PlayerState;
using UnityEngine;

public class Jump : State
{
    public Jump(StateManager stateManager, Factory factory) 
        : base(stateManager, factory) {}

    public override void Enter()
    {
        Debug.Log("Enter Jump");
    }
    public override void Update()
    {
        _ctx.moveManager.Move();

        if (_ctx.moveManager.GetVelocityY() <= 0)
        {
            _currentParentState.SwitchSubState(_factory.GetFall());
        }
    }
    public override void Exit()
    {
        Debug.Log("Exit Jump");
    }
}
