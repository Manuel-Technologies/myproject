using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Security.Cryptography;
using System.IO;
using System.IO.Pipelines;

public class Program
{
    public static void Main()
    {
        Console.WriteLine($"welcome to tempConva .... the ultimate temperature converter");

        System.Console.WriteLine("which unit do you want to convert to ?");
        System.Console.WriteLine("1. celsius to fahrenheit ");
        Console.WriteLine("2. Fahrenheit to celsius");
        Console.WriteLine("3. celsius to kelvin") ;

        string userInput = Console.ReadLine();

        System.Console.WriteLine("---------------------");
        System.Console.WriteLine("input the value you want to convert");
        double valueToConvert = double.Parse(Console.ReadLine());

        if(userInput=="1")
        {
          double result= ConvertFromCelsiusToFahrenheit(valueToConvert);

          System.Console.WriteLine($"the result is {result}F");
        }

        if (userInput=="2")
        {
            double result = ConvertFomFahrenheitToCelsius(valueToConvert);
            System.Console.WriteLine($"the result is {result}C");
        }

    }

    public static double ConvertFromCelsiusToFahrenheit(double valueToConvert)
    {
        double fahrenheit = (valueToConvert * 9 / 5) + 32;
        return fahrenheit;
    }

    public static double ConvertFomFahrenheitToCelsius(double valueToConvert)
    {
        double celsius = (valueToConvert-32)*5/9;
        return celsius;
    }





}
