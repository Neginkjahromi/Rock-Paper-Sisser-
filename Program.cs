using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Random pc = new Random();
            int pcCoice = pc.Next(1, 4);
            string pcCoiceString = "", userChoiceString = "";
            switch (pcCoice)
            {
                case 1:
                    pcCoiceString = "Rock";
                    break;
                case 2:
                    pcCoiceString = "Paper";
                    break;
                case 3:
                    pcCoiceString = "Sisser";
                    break;
            }
            Console.WriteLine("     1 --> Rock");
            Console.WriteLine("     2 --> Paper");
            Console.WriteLine("     3 --> Sisser");
            Console.Write("     Chose a number from the menu above --> ");
            try
            {
                int userChoice = Convert.ToInt32(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        userChoiceString = "Rock";
                        break;
                    case 2:
                        userChoiceString = "Paper";
                        break;
                    case 3:
                        userChoiceString = "Sisser";
                        break;
                    default:
                        Console.WriteLine("     Enter a number from 1 to 3");
                        break;
                }
                if (pcCoice == userChoice)
                {
                    Console.WriteLine("    *Equaled*");
                    Console.WriteLine($"    Computer: {pcCoiceString}");
                    Console.WriteLine($"         You: {userChoiceString}");
                }
                else if ((pcCoice == 2 && userChoice == 1) || (pcCoice == 3 && userChoice == 2) || (pcCoice == 1 && userChoice == 3))
                {
                    Console.WriteLine("    *You Lose*");
                    Console.WriteLine($"    Computer: {pcCoiceString}");
                    Console.WriteLine($"         You: {userChoiceString}");
                }
                else if ((pcCoice == 3 && userChoice == 1) || (pcCoice == 1 && userChoice == 2) || (pcCoice == 2 && userChoice == 3))
                {
                    Console.WriteLine("    *You Win*");
                    Console.WriteLine($"    Computer: {pcCoiceString}");
                    Console.WriteLine($"         You: {userChoiceString}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("     Enter a number from 1 to 3");
                throw;
            }
        }
    }
}