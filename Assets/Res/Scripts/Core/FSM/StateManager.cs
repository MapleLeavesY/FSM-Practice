using UnityEngine;

namespace State
{
    public class StateManager : MonoBehaviour
    {
        public StateBase stateManager;
        public AnimationState_Idle animationState_Idle = new AnimationState_Idle();
        public AnimationState_Run animationState_Run = new AnimationState_Run();
        public AnimationState_Up animationState_Up = new AnimationState_Up();

        private void Start()
        {
            stateManager = animationState_Idle;
            stateManager.StateEnter(this);
        }
        private void Update()
        {
            stateManager.StateUpdate(this);
        }

        public void SwitchState(StateBase stateBase)
        {
            stateManager = stateBase;
            stateManager.StateEnter(this);
        }
    }
}