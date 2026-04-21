namespace PlayerState
{
    public abstract class BaseState 
    {
        protected StateManager _stateManager;
        protected Factory _factory;
        public BaseState(StateManager stateManager, Factory factory)
        {
            _stateManager = stateManager;
            _factory = factory;
        }
        public virtual void StateEnter() {}
        public virtual void StateUpdate() {}
        public virtual void StateExit() {}
    }
}