using Unity.VisualScripting;
using UnityEngine;


namespace State
{
    public abstract class StateBase
    {

        public virtual void StateEnter(StateManager stateManager){}
        public virtual void StateUpdate(StateManager stateManager){}
        public virtual void StateExit(StateManager stateManager){}
        


    }
}