class AEFactory : AbstractFactory
{
    public Pants create_pants()
    {
        return new AEPant();
    }
    public Jackets create_jackets()
    {
        return new AEJacket();
    }
    public Shirts create_shirts()
    {
        return new AEShirt();
    }
    
}