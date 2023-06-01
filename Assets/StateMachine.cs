using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private State currentState;

    private void Start()
    {
        // Ustal stan początkowy jako Idle
        TransitionToState(new IdleState(this));
    }

    private void Update()
    {
        // Aktualizuj bieżący stan
        currentState.UpdateState();
    }

    public void TransitionToState(State nextState)
    {
        // Zmiana stanu
        if (currentState != null)
        {
            currentState.ExitState();
        }

        currentState = nextState;
        currentState.EnterState();
    }
}

