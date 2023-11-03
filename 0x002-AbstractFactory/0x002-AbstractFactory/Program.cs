// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

//Console.WriteLine("Hello, World!");

internal class Program
{
    static void Main(string[] args)
    {
        string cardNumber, bankCode;

        BankFactory  bankfactory = new BankFactory();

        Console.WriteLine("Enter your card number");
        cardNumber = Console.ReadLine();
        bankCode = cardNumber.Substring(0,6);

        I_Bank bank = bankfactory.getBank(bankCode);

        Console.WriteLine(bank.withdraw());    
        
        
        }
}