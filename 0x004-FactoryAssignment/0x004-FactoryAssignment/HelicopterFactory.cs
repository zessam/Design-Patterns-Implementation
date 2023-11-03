class HelicopterFactory : MilitaryVehicleFactory
{
    public override MilitaryVehicle CreateVehicle()
    {
        return new Helicopter();
    }
}
