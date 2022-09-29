// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

class Converter
{
    public Converter() { }
    static decimal DollarExchangeRate;
    static decimal EuroExchangeRate;
    
    public Converter(decimal DollarRate, decimal EuroRate)
       { 
        DollarExchangeRate = DollarRate; 
        EuroExchangeRate = EuroRate;
       }
    public void ConvertToUAH(decimal number, string? name)
    {
        decimal result;
        if (name == "dollar")
        {
            result = number * DollarExchangeRate;

        }
        else if (name == "euro")
        {
            result = number * EuroExchangeRate;
        }
        else
        {
            return;
        }
        Console.WriteLine("Number in UAH: " + result.ToString() + "\n");
    }
    public void ConvertToCurrency(decimal number, string? name)
    {
        decimal result;
        if (name == "dollar")
        {
            result = number / DollarExchangeRate;

        }
        else if (name == "euro")
        {
            result = number / EuroExchangeRate;
        }
        else
        {
            return;
        }
        Console.WriteLine("Number in foreign currency: " + result.ToString() + "\n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Do you want to conduct an exchange? (yes or no):  ");
        string a = Console.ReadLine();
        if (a == "yes")
        {

            Console.WriteLine("Enter dollar exchange rate:");
            decimal DollarRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter euro exchange rate:");
            decimal EuroRate = Convert.ToDecimal(Console.ReadLine());
            Converter converter = new Converter(DollarRate, EuroRate);


            Console.WriteLine("Do you want to convert from foreigh currency to UAH? (yes or no):  ");
            string b = Console.ReadLine();
            if (b == "yes")
            {
                Console.WriteLine("Enter the amount you want to convert from foreigh currency to UAH: ");
                decimal number;
                number = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter the currency(dollar/euro): ");
                string? ans = Console.ReadLine();
                converter.ConvertToUAH(number, ans);
            } 

            Console.WriteLine("Do you want to convert from UAH to foreigh currency? (yes or no):  ");
            string c = Console.ReadLine();
            if (c == "yes")
            {
            Console.WriteLine("Enter the amount you want to convert from UAH to foreigh currency: ");
            decimal number_;
            number_ = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the currency(dollar/euro): ");
            string? ans_ = Console.ReadLine();

            converter.ConvertToCurrency(number_, ans_);
            } 
        } 
    }
}