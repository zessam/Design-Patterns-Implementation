class ChanelFactory : AbstractFactory
{
    public Pants create_pants()
    {
        return new ChanelPant();
    }
    public Jackets create_jackets()
    {
        return new ChanelJacket();
    }
    public Shirts create_shirts()
    {
        return new ChanelShirt();
    }
}