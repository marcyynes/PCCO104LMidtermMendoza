using System;

class Program
{
    static void Main(string[] args)
    {
        int baseFanPower = 10;
        int fanSpeed = 0;
        char oscillateOption = ' ';

        while (fanSpeed < 1 || fanSpeed > 3)
        {
            Console.Write("Enter fan speed (1, 2, or 3): ");
            if (!int.TryParse(Console.ReadLine(), out fanSpeed) || fanSpeed < 1 || fanSpeed > 3)
            {
                Console.WriteLine("Invalid input! Please enter a valid fan speed.");
            }
        }

        while (oscillateOption != 'Y' && oscillateOption != 'N')
        {
            Console.Write("Do you want to oscillate? (Y/N): ");
            oscillateOption = char.ToUpper(Console.ReadKey().KeyChar);
            if (oscillateOption != 'Y' && oscillateOption != 'N')
            {
                Console.WriteLine("\nInvalid input! Please enter 'Y' or 'N'.");
            }
            else
            {
                Console.ReadLine();
            }
        }

        int fanPowerOutput = baseFanPower * fanSpeed;

        if (oscillateOption == 'Y')
        {
            for (int i = 1; i <= fanPowerOutput; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("~");
                    }
                    Console.WriteLine();
                }
            }

            for (int i = fanPowerOutput - 1; i >= 1; i--)
            {
                if (i % 2 != 0)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("~");
                    }
                    Console.WriteLine();
                }
            }
        }
        else 
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(new string('~', fanPowerOutput));
            }
        }
    }
}