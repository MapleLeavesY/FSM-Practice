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
        private State _isAir;
        private State _idel;
        private State _run;
        private State _fall;
        private State _jump;
        public State GetIsGround()
        {
            return _isGround ??= new IsGround(_ctx, this);
        }
        public State GetIsAir()
        {
            return _isAir ??= new IsAir(_ctx, this);
        }
        public State GetIdle()
        {
            return _idel ??= new Idel(_ctx, this);
        }
        public State GetRun()
        {
            return _run ??= new Run(_ctx, this);
        }
        public State GetJump()
        {
            return _jump ??= new Jump(_ctx, this);
        }
        public State GetFall()
        {
            return _fall ??= new Fall(_ctx, this);
        }
    }
}