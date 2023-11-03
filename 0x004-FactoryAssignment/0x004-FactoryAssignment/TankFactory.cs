class TankFactory : MilitaryVehicleFactory
{
    public override MilitaryVehicle CreateVehicle()
    {
        return new Tank();
    }
}