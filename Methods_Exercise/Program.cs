using System;
using System.Collections.Generic;

namespace Methods_Exercise
{
    internal class Program
    {   // exercise part 1
        private static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("How tall are you?");
            string userHeight = Console.ReadLine();

            Console.WriteLine("Whats your fav resturant?");
            string userFavdish = Console.ReadLine();

            Console.WriteLine("Whats your dogs name?");
            string userDogName = Console.ReadLine();

            Console.WriteLine($"There was a man named {userName}, he was {age} years old.");
            Console.WriteLine($"He was {userHeight}, and loved to eat at {userFavdish}!");
            Console.WriteLine($"{userName} loves to take is his pet dog {userDogName} on morning walks. ");


            // exercise part 2
            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2, 2, 3, 5, 7);
            Console.WriteLine($"The sum is:{sum}");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is:{product}");
        }


        //challange mode
        public static int Sum(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;
        }

    }

    public static int Sum(int num1, int num2)
    {
        //int sum = num1 + num2;

        //return sum;

        return num1 + num2;
    }

    public static int Multiply(int x, int y)
    {
        return x * y;

    }
}
}
