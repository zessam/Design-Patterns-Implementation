class DiorFactory : AbstractFactory
{
    public Pants create_pants()
    {
        return new DiorPant();
    }
    public Jackets create_jackets()
    {
        return new DiorJacket();
    }
    public Shirts create_shirts()
    {
        return new DiorShirt();
    }
}