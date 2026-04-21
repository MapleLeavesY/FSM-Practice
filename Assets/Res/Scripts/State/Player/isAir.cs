using PlayerState;
using UnityEngine;

public class isAir : BaseState
{
    public isAir(StateManager stateManager, Factory factory) : base(stateManager, factory){}
    
    public override void StateEnter()
    {
        Debug.Log("welcome Enter isAirState!");
    }
    public override void StateUpdate()
    {
            
    }
    public override void StateExit()
    {
        Debug.Log("welcome Exit isAirState!");
    }

}
