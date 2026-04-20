using UnityEngine;


namespace State
{
    public class AnimationState_Up : StateBase
    {
        public override void StateEnter(StateManager stateManager)
        {
            Debug.Log("Entering the UPEnter stage");
        }
        public override void StateUpdate(StateManager stateManager)
        {
            
        }

        public override void StateExit(StateManager stateManager)
        {
            throw new System.NotImplementedException();
        }
    }
}