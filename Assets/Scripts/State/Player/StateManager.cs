
using UnityEngine;
namespace PlayerState
{
    public class StateManager : MonoBehaviour
    {
        [HideInInspector] public State currentState;
        [HideInInspector] public Factory factory;
        [HideInInspector] public MoveManager moveManager; 
        private void Awake()
        {
            moveManager = GetComponent<MoveManager>();
            factory = new Factory(this);
            currentState  = factory.GetIsGround();
            currentState.Enter();
        }
        private void Update()
        {
            currentState.Update();
        }

        public void SwitchState(State newState)
        {
            if(currentState == newState) return;
            currentState?.Exit();
            currentState = newState;
            currentState.Enter();
        }

    }
}