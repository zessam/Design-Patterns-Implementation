class Client {
  public AbstractFactory factory;

  public AbstractFactory getbrand(string brand){
    if (brand == "AE")
    {
        factory = new AEFactory();      
    }
    else if (brand == "Dior")
    {
        factory = new DiorFactory();      
    }
    else if (brand == "Chanel")
    {
        factory = new ChanelFactory();      
    }
    else if (brand == "LV")
    {
        factory = new LVFactory();      
    }
    return factory;
  }

 
  
}