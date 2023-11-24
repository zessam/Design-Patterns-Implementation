class Program
{
    static void Main()
    {
        // Create strategies
        IStrategy strategyA = new ConcreteStrategyA();
        IStrategy strategyB = new ConcreteStrategyB();

        // Create context with the initial strategy
        Context context = new Context(strategyA);

        // Execute the initial strategy
        context.ExecuteStrategy();

        // Change strategy at runtime
        context.SetStrategy(strategyB);

        // Execute the new strategy
        context.ExecuteStrategy();
    }
}
