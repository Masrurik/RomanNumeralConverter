using System;

namespace RomanNumeralConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please choose a number from 1 to 10:");
            string num=Console.ReadLine();
            switch (num)
            {
                case "1":
                    Console.Write("I");
                    break;
                case "2":
                    Console.Write("II");
                    break;
                case "3":
                    Console.Write("III");
                    break;
                case "4":
                    Console.Write("IV");
                    break;
                case "5":
                    Console.Write("V");
                    break;
                case "6":
                    Console.Write("VI");
                    break;
                case "7":
                    Console.Write("VII");
                    break;
                case "8":
                    Console.Write("VIII");
                    break;
                case "9":
                    Console.Write("IX");
                    break;
                case "10":
                    Console.Write("X");
                    break;

                default:
                    Console.Write("Error please choose a number from 1 to 10");
                    break;
            }


        }
    }
}
