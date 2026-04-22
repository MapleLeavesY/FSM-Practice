namespace PlayerState
{
    public abstract class State
    {
        protected StateManager _ctx;
        protected Factory _factory;
        protected State _currentParentState;
        protected State _currentSubState;
        public State(StateManager stateManager, Factory factory)
        {
            _ctx = stateManager;
            _factory = factory;
        }
        public virtual void Enter(){}
        public virtual void Update(){}
        public virtual void Exit(){}

        #region 第二层状态机更换
        public void SwitchSubState(State newstate)
        {
            _currentSubState?.Exit();
            _currentSubState = newstate;
            newstate._currentParentState = this;
            _currentSubState.Enter();
        }

        public void SubUpdate()
        {
            _currentSubState?.Update();
        }
        #endregion
        #region 第一层状态机更换
       public void SwitchParentState(State state)
        {
            _ctx.SwitchState(state);
        }


        #endregion
    }
}