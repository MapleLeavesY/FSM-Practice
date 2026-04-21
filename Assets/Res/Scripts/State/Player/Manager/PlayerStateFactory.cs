using JetBrains.Annotations;
using UnityEngine;
namespace PlayerState
{
    public class Factory
    {
        private StateManager _stateManager;
        private isGround _isGround;
        private isAir _isAir ;
        private Idle _idleState;
        private Run _runState;
        public Factory(StateManager stateManager)
        {
            _stateManager = stateManager;
        }
        public BaseState GetIdleState()
        {
            return _idleState ??= new Idle(_stateManager, this);
        }
        public BaseState GetRunState()
        {
            return _runState ??= new Run(_stateManager, this);
        }
        public BaseState GetIsGroundState()
        {
            return _isGround ??= new isGround(_stateManager, this);
        }
        public BaseState GetIsAirState()
        {
            return _isAir ??= new isAir(_stateManager, this);
        }
    }
}