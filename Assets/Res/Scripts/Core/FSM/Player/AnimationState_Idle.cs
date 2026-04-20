using UnityEngine;
using UnityEngine.InputSystem;


namespace State
{
    public class AnimationState_Idle : StateBase
    {
        public override void StateEnter(StateManager stateManager)
        {
            Debug.Log("Entering the IdleEnter stage");
        }
        public override void StateUpdate(StateManager stateManager)
        {
            if(Keyboard.current.aKey.isPressed ||
               Keyboard.current.dKey.isPressed)
            {
                stateManager.SwitchState(stateManager.animationState_Run);
                StateExit(stateManager);
            }
            if(Keyboard.current.wKey.isPressed)
            {
                stateManager.SwitchState(stateManager.animationState_Up);
                StateExit(stateManager);
            }
        }

        public override void StateExit(StateManager stateManager)
        {
            Debug.Log("Exit IDLE");
        }
    }
}