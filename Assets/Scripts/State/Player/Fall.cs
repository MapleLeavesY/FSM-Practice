using PlayerState;
using UnityEngine;

public class Fall : State
{
    public Fall(StateManager stateManager, Factory factory) 
        : base(stateManager, factory) {}
    public override void Enter()
    {
        Debug.Log("Enter Fall");
    }
    public override void Update()
    {
        _ctx.moveManager.Move();
    }
    public override void Exit()
    {
        Debug.Log("Exit Fall");
    }
}
