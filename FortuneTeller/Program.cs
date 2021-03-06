﻿using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";
            int age = 0;
            int birthMonth = 0;
            string color = "";
            int numSiblings = 0;
            int retirement = 0;
            string vacation = "";
            string transport = "";
            string balance = "";
            string input = "";

            Console.WriteLine("Let's predict your future. Tell me your first name.");
            firstName = Console.ReadLine();
            if (firstName.Equals("Quit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Nobody likes a quitter...");
                Environment.Exit(0);
            }

            Console.WriteLine("Now tell me your last name.");
            lastName = Console.ReadLine();
            if (lastName.Equals("Quit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Nobody likes a quitter...");
                Environment.Exit(0);
            }

            try
            {
                
                Console.WriteLine("What is your age?");
                input = Console.ReadLine();
                if (input.Equals("Quit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    Environment.Exit(0);
                }
                age = int.Parse(input);
                Console.WriteLine("What is your birth month (1-12)?");
                input = Console.ReadLine();
                if (input.Equals("Quit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    Environment.Exit(0);
                }
                birthMonth = int.Parse(input);
                Console.WriteLine("How many siblings do you have?");
                input = Console.ReadLine();
                if (input.Equals("Quit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    Environment.Exit(0);
                }
                numSiblings = int.Parse(input);

            }
            catch (FormatException)
            {
                Console.WriteLine("You're input is invalid. Try again!");
            }

            Console.WriteLine("What is your favorite ROYGBIV color (Please type in lower case)? Type 'Help' for list of colors.");
            color = Console.ReadLine();
            while (color.Equals("Help", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Colors are red, orange, yellow, green, blue, indigo, and violet. Enter your favorite color.");
                color = Console.ReadLine();
            }
            if (color.Equals("Quit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Nobody likes a quitter...");
                Environment.Exit(0);
            }

            //This loop figures out the years until retirement.
            if (age % 2 == 0)
            {
                retirement = 12;
            }
            else
            {
                retirement = 14;
            }

            //This loop figures out the vacation location based on number of siblings.
            if (numSiblings.Equals(0))
            {
                vacation = "Boca Raton, FL";
            }
            else if (numSiblings.Equals(1))
            {
                vacation = "Nassau, Bahamas";
            }
            else if (numSiblings.Equals(2))
            {
                vacation = "Ponta Negra, Brazil";
            }
            else if (numSiblings.Equals(3))
            {
                vacation = "Portland, Oregon";
            }
            else if (numSiblings > 3)
            {
                vacation = "Baton Rouge, LA";
            }
            else
            {
                vacation = "Chernobryl, Ukraine";
            }

            //Switch statement to determine mode of transport
            switch (color)
            {
                case "red":
                    transport = "Maserati";
                    break;
                case "orange":
                    transport = "Stallion";
                    break;
                case "yellow":
                    transport = "Chariot";
                    break;
                case "green":
                    transport = "Taxi";
                    break;
                case "blue":
                    transport = "Rickshaw";
                    break;
                case "indigo":
                    transport = "Motor Scooter";
                    break;
                case "violet":
                    transport = "Flying Saucer";
                    break;
                default:
                    transport = "walking (since you didn't put the right color)";
                    break;
            }

            //This loop determines the user's balance.
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                balance = "$256,000.76";
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                balance = "$3,687,105.42";
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                balance = "$86.23";
            }
            else
            {
                balance = "$0.00";
            }

            Console.WriteLine(firstName + " " + lastName + " will retire in " + retirement + " years with " + balance + " in the bank,");
            Console.WriteLine(" a vacation home in " + vacation + ", and travel by " + transport + ".");

        }
    }
}
