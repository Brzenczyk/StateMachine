public abstract class State
{
    protected StateMachine stateMachine;

    public State(StateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    public abstract void EnterState();

    public abstract void UpdateState();

    public abstract void ExitState();
}
