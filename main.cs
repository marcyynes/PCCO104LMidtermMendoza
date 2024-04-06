using System;

class Program
{
    static void Main(string[] args)
    {
        int baseFanPower = 10;
        int fanSpeed;
        string oscillateOption;

        while (true)
        {
            Console.Write("Enter fan speed (1, 2, or 3): ");
            fanSpeed = Convert.ToInt32(Console.ReadLine());

            if (fanSpeed >= 1 && fanSpeed <= 3)
                break;

            Console.WriteLine("INVALID value. Please enter again.");
        }

        while (true)
        {
            Console.Write("Enter oscillate option (Y or N): ");
            oscillateOption = Console.ReadLine().ToUpper();

            if (oscillateOption == "Y" || oscillateOption == "N")
                break;

            Console.WriteLine("INVALID value. Please enter again.");
        }

        int fanPowerOutput = baseFanPower * fanSpeed;

        if (oscillateOption == "Y")
        {
            for (int i = fanSpeed; i <= fanPowerOutput; i += fanSpeed)
            {
                Console.WriteLine(new string('~', i));
            }

            for (int i = fanPowerOutput; i >= fanSpeed; i -= fanSpeed)
            {
                Console.WriteLine(new string('~', i));
            }
        }
        else
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new string('~', fanPowerOutput));
            }
        }
    }
}