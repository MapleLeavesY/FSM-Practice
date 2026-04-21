using UnityEngine;

namespace PlayerState
{
    public class Run : BaseState
    {
        public Run(StateManager stateManager, Factory factory) : base(stateManager, factory)
        {}
        public override void StateEnter()
        {
            Debug.Log("welcome Enter RunState!");
        }
        public override void StateUpdate()
        {
            _stateManager._playerManager.PlayerMove();
            if(_stateManager._playerManager.GetPlayerMove() == Vector2.zero)
                _stateManager.SwitchState(_factory.GetIdleState());
        }
        public override void StateExit()
        {
            Debug.Log("welcome Exit RunState!");
        }
    }
}