class BankFactory: I_BankFactory
{

    public I_Bank getBank(string cardNumber)
    {
        if (cardNumber == "123456")
        {
            return new bankA();
        }
         else if (cardNumber == "654231")
    {
          return new bankB();
    }
    return null;
    }
   
}