using Unity.VisualScripting;
using UnityEngine;
namespace PlayerState
{
    public class Factory
    {
        private StateManager _ctx;
        public Factory(StateManager stateManager)
        {
            _ctx = stateManager;
        }
        private State _isGround;
        private State _idel;
        private State _run;
        public State GetIsGround()
        {
            return _isGround ??= new IsGround(_ctx, this);
        }
        public State GetIdle()
        {
            return _idel ??= new Idel(_ctx, this);
        }
        public State GetRun()
        {
            return _run ??= new Run(_ctx, this);
        }
    }
}