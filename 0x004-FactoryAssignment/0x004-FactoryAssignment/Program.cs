class Program
{
    static void ConductMilitaryOperation(MilitaryVehicleFactory factory)
    {
        var vehicle = factory.CreateVehicle();
        Console.WriteLine(vehicle.Deploy());
        Console.WriteLine(vehicle.Retreat());
    }

    static void Main(string[] args)
    {
        // Deploy Tank 
        MilitaryVehicleFactory tankFactory = new TankFactory();
        ConductMilitaryOperation(tankFactory);

        // Deploy Hel
        MilitaryVehicleFactory helicopterFactory = new HelicopterFactory();
        ConductMilitaryOperation(helicopterFactory);
    }
}