class LVFactory : AbstractFactory
{
    public Pants create_pants()
    {
        return new LVPant();
    }
    public Jackets create_jackets()
    {
        return new LVJacket();
    }
    public Shirts create_shirts()
    {
        return new LVShirt();
    }
}