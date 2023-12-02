class SRE
{
    private ISREState currentState;

    public SRE()
    {
        // Initial state is Writing Code
        currentState = new WritingCodeState();
    }

    public void SetState(ISREState state)
    {
        currentState = state;
    }

    public void PerformDailyTasks()
    {
        currentState.ExecuteSRETask(this);
    }
}

