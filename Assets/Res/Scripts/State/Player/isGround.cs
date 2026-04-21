using PlayerState;
using UnityEngine;

public class isGround : BaseState
{
    public isGround(StateManager stateManager, Factory factory) : base(stateManager, factory){}
    public override void StateEnter()
    {
        Debug.Log("welcome Enter isGroundState!");
    }
    public override void StateUpdate()
    {
        if(_stateManager.IsGround)
        {//在陆地上
            if(_stateManager._playerManager.GetPlayerMove() == Vector2.zero)
            {//IDLE
                _stateManager.SwitchState(_factory.GetIdleState());
            }
            if(_stateManager._playerManager.GetPlayerMove() != Vector2.zero)
            {//RUN
                _stateManager.SwitchState(_factory.GetRunState());
            }
            return;
        }
        _stateManager.SwitchState(_factory.GetIsAirState());
    }
    public override void StateExit()
    {
        Debug.Log("welcome Exit isGroundState!");
    }
        
}
