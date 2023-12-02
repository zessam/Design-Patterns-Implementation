// State 2: Solving Issues
class SolvingIssuesState : ISREState
{
    public void ExecuteSRETask(SRE sre)
    {
        Console.WriteLine("SRE is Solving Issues.");
        // Switch to the next state
        sre.SetState(new MonitoringEnvironmentState());
    }
}