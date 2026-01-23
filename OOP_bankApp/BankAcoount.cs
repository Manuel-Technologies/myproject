public class BankAccount
{
    public string name { get; set; }
    public double balance { get; set; }

    public void AddMoney()
    {
        System.Console.WriteLine("how much do you want to deposit ?");
        double AmountToAdd;
        AmountToAdd = double.Parse(Console.ReadLine());
        this.balance += AmountToAdd;
        System.Console.WriteLine($"you have succesfully deposited ${AmountToAdd} and your balance is now ${balance}");
    }

    public void RemoveMoney()
    {
        Console.WriteLine("how much do you want to withdraw or transfer ?");
        double AmountToRemove;
        AmountToRemove = double.Parse(Console.ReadLine());

        if (AmountToRemove <= 0)
        {
            Console.WriteLine("the withdrawal amount must be less than 0");
        }
        else if (AmountToRemove > balance)
        {
            Console.WriteLine("the withdrawal amount must not be greater than the balance");
        }
        else
        {
            this.balance -= AmountToRemove;
            Console.WriteLine($"you have successfuly transfered ${AmountToRemove} and your balance is now ${balance}");
        }
    }

    public void CheckBalance ()
    {
        
        Console.WriteLine($"your account balance is  ${this.balance}");
    }
}
