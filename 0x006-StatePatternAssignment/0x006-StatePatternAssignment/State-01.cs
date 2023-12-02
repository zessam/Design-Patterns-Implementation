// State 1: Writing Code
class WritingCodeState : ISREState
{
    public void ExecuteSRETask(SRE sre)
    {
        Console.WriteLine("SRE is Writing Code.");
        // Switch to the next state
        sre.SetState(new SolvingIssuesState());
    }
}