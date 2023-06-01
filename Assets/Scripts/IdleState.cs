using UnityEngine;

public class IdleState : State
{
    public IdleState(StateMachine stateMachine) : base(stateMachine) { }

    public override void EnterState()
    {
        Debug.Log("Idle state entered");
    }

    public override void UpdateState()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            stateMachine.TransitionToState(new JumpState(stateMachine));
        }
        else if (Input.GetKey(KeyCode.W))
        {
            stateMachine.TransitionToState(new WalkState(stateMachine));
        }
    }

    public override void ExitState()
    {
        Debug.Log("Idle state exited");
    }
}
