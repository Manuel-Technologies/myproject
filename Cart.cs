using System;

using System.Linq;

using System.Collections.Generic;



namespace program;



public class simpleCart
{
    public static void Main()
    {

        List<string> foods = new List<string>();
        List<double> prices = new List<double>();



        double total = 0;

        while (true)
        {
            Console.WriteLine("enter a food to buy or S to stop");
            string foodInput = Console.ReadLine();

            if (foodInput.ToLower() == "s") break;
            else
            {
                foods.Add(foodInput);

            }

            Console.WriteLine("input the price of the food");
            double priceInput = double.Parse(Console.ReadLine());
            prices.Add(priceInput);
            total = prices.Sum();

        }
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("-----------------------YOUR CART---------------------");



        //Console.WriteLine(foods);
        // Console.WriteLine(price);

        foreach (var item in foods)
        {
            //Console.WriteLine(foods);
            Console.WriteLine(item);
        }

        Console.WriteLine("this are the prices");

        foreach (var item in prices)
        {
            Console.WriteLine($"₦{item}");

        }

        Console.WriteLine("");
        Console.WriteLine('----------------------------------');


        Console.WriteLine($"your total expenses is ₦{total}");

    }

}

