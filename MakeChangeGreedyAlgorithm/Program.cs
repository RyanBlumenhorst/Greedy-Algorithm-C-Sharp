using System;

public class MakeChange
{
    public static void change (double cost, double paid)
    {
        //Find total amount of change
        double amount = paid - cost;
        amount = Math.Round(amount, 2);

        //Variables for each bill and coin
        int hundreds = 0;
        int fifties = 0;
        int twenties = 0;
        int tens = 0;
        int fives = 0;
        int ones = 0;
        int quarters = 0;
        int dimes = 0;
        int nickles = 0;
        int pennies = 0;

        //Works down the list, starting with the biggest bill and working down to pennies. If amount is bigger than the bill or coin, add one to their counter and reduce amount by the value of the bill or coin
        while (amount >= 100)
        {
            hundreds++;
            amount = Math.Round(amount - 100, 2);
        }
        while (amount >= 50)
        {
            fifties++;
            amount = Math.Round(amount - 50, 2);
        }
        while (amount >= 20)
        {
            twenties++;
            amount = Math.Round(amount - 20, 2);
        }
        while (amount >= 10)
        {
            tens++;
            amount = Math.Round(amount - 10, 2);
        }
        while (amount >= 5)
        {
            fives++;
            amount = Math.Round(amount - 5, 2);
        }
        while (amount >= 1)
        {
            ones++;
            amount = Math.Round(amount - 1, 2);
        }
        while (amount >= 0.25)
        {
            quarters++;
            amount = Math.Round(amount - 0.25, 2);
        }
        while (amount >= 0.10)
        {
            dimes++;
            amount = Math.Round(amount - 0.1, 2);
        }
        while (amount >= 0.05)
        {
            nickles++;
            amount = Math.Round(amount - 0.05, 2);
        }
        while (amount >= 0.01)
        {
            pennies++;
            amount = Math.Round(amount - 0.01, 2);
        }

        //Print out variables for change. This will only print an amount if you are supposed to get one or more back (ex. it won't say "0 Hundred Dollar Bills")
        Console.WriteLine("Your Change:");
        
        if (hundreds > 0)
        {
            if (hundreds == 1)
            {
                Console.WriteLine("1 Hundred Dollar Bill");
            }
            else
            {
                Console.WriteLine(hundreds + " Hundred Dollar Bills");
            }
        }
        if (fifties > 0)
        {
            if (fifties == 1)
            {
                Console.WriteLine("1 Fifty Dollar Bill");
            }
            else
            {
                Console.WriteLine(fifties + " Fifty Dollar Bills");
            }
        }
        if (twenties > 0)
        {
            if (twenties == 1)
            {
                Console.WriteLine("1 Twenty Dollar Bill");
            }
            else
            {
                Console.WriteLine(twenties + " Twenty Dollar Bills");
            }
        }
        if (tens > 0)
        {
            if (tens == 1)
            {
                Console.WriteLine("1 Ten Dollar Bill");
            }
            else
            {
                Console.WriteLine(tens + " Ten Dollar Bills");
            }
        }
        if (fives > 0)
        {
            if (fives == 1)
            {
                Console.WriteLine("1 Five Dollar Bill");
            }
            else
            {
                Console.WriteLine(fives + " Five Dollar Bills");
            }
        }
        if (ones > 0)
        {
            if (ones == 1)
            {
                Console.WriteLine("1 One Dollar Bill");
            }
            else
            {
                Console.WriteLine(ones + " One Dollar Bills");
            }
        }
        if (quarters > 0)
        {
            if (quarters == 1)
            {
                Console.WriteLine("1 Quarter");
            }
            else
            {
                Console.WriteLine(quarters + " Quarters");
            }
        }
        if (dimes > 0)
        {
            if (dimes == 1)
            {
                Console.WriteLine("1 Dime");
            }
            else
            {
                Console.WriteLine(dimes + " Dimes");
            }
        }
        if (nickles > 0)
        {
            if (nickles == 1)
            {
                Console.WriteLine("1 Nickle");
            }
            else
            {
                Console.WriteLine(nickles + " Nickles");
            }
        }
        if (pennies > 0)
        {
            if (pennies == 1)
            {
                Console.WriteLine("1 Penny");
            }
            else
            {
                Console.WriteLine(pennies + " Pennies");
            }
        }
        


    }
    
    public static void Main(string[] args)
    {
        try
        {
            //Prompt
            Console.WriteLine("Enter the cost:");
            double cost = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
            Console.WriteLine("Enter how much you paid");
            double paid = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
            //Run Module
            change(cost, paid);
        } catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}
