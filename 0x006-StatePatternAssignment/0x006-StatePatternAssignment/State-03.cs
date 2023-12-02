// State 3: Monitoring the Environment
class MonitoringEnvironmentState : ISREState
{
    public void ExecuteSRETask(SRE sre)
    {
        Console.WriteLine("SRE is Monitoring the Environment.");
        // Switch to the next state 
        sre.SetState(new WritingCodeState());
    }
}