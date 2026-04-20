using UnityEngine;


namespace State
{
    public class AnimationState_Run : StateBase
    {
        public override void StateEnter(StateManager stateManager)
        {
            Debug.Log("Entering the RunEnter stage");
        }
        public override void StateUpdate(StateManager stateManager)
        {
            throw new System.NotImplementedException();
        }

        public override void StateExit(StateManager stateManager)
        {
            throw new System.NotImplementedException();
        }
    }
}