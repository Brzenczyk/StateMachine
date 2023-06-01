using UnityEngine;

public class JumpState : State
{
    public JumpState(StateMachine stateMachine) : base(stateMachine) { }

    public override void EnterState()
    {
        Debug.Log("Jump state entered");
    }

    public override void UpdateState()
    {
        if (!Input.GetKey(KeyCode.Space))
        {
            stateMachine.TransitionToState(new IdleState(stateMachine));
        }
    }

    public override void ExitState()
    {
        Debug.Log("Jump state exited");
    }
}