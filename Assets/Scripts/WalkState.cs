using UnityEngine;

public class WalkState : State
{
    public WalkState(StateMachine stateMachine) : base(stateMachine) { }

    public override void EnterState()
    {
        Debug.Log("Walk state entered");
    }

    public override void UpdateState()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            stateMachine.TransitionToState(new JumpState(stateMachine));
        }
        else if (!Input.GetKey(KeyCode.W))
        {
            stateMachine.TransitionToState(new IdleState(stateMachine));
        }
    }

    public override void ExitState()
    {
        Debug.Log("Walk state exited");
    }
}

