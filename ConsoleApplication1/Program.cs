using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
        }

        static void DisplayMenu()
        {
            int inputOption = 0;
            Console.WriteLine("Type:");
            Console.WriteLine("1 to test circles");
            Console.WriteLine("2 to test deck");
            Console.WriteLine("3 to test array sort");
            Console.WriteLine("4 to exit the program");
            int.TryParse(Console.ReadLine(), out inputOption);
            switch (inputOption)
            {
                case 1: RunCirclesTest();
                    break;
                case 2: RunDeckTest(new Deck());
                    break;
                case 3: RunArrayTest();
                    break;
                case 4: Environment.Exit(0);
                    break;
                default:
                    DisplayMenu();
                    break;
            }
            Console.Read();//prevent the console from closing immediately.
        }

        static void RunArrayTest()
        {
            int[] firstArray, secondArray, outputArray;
            string inputNumbers;

            Console.WriteLine("Enter a list ofnumbers seperated by commas for the first array");
            inputNumbers = Console.ReadLine();
            firstArray = parseArray(inputNumbers);

            Console.WriteLine("Enter a list of numbers seperated by commas for the second array");
            inputNumbers = Console.ReadLine();
            secondArray = parseArray(inputNumbers);

            outputArray = ArraySorting.sortTwoArrays(firstArray,secondArray);
            Console.WriteLine("The combined and sorted array is: ");
            foreach (int number in outputArray)
                Console.Write(number.ToString());

        }

        static void RunDeckTest(Deck deck)
        {
            Card topCard;
            int inputOption = 0;


            while (true)
            {
            Console.WriteLine("Type:");
            Console.WriteLine("1 to shuffle the deck,");
            Console.WriteLine("2 to look at the top card,");
            Console.WriteLine("3 shuffle all cards back into the deck.");
            int.TryParse(Console.ReadLine(), out inputOption);
                switch (inputOption)
                {
                    case 1: Console.WriteLine("You typed: " + inputOption);
                        deck.ShuffleCards();
                        break;
                    case 2:
                        topCard = deck.TakeTopCard();
                        Console.WriteLine("The top Card is: ");
                        Console.WriteLine(topCard.CardValue + " of " + topCard.CardSuit);
                        break;
                    case 3: deck = new Deck();
                        break;
                    default:
                        break;
                }
               
            }
        }

        static void RunCirclesTest()
        {
            Circle circle1 = MakeCircle();
            Circle circle2 = MakeCircle();
            if (circle1.IntersectsWith(circle2))
                Console.WriteLine("These circles intersect.");
            else
                Console.WriteLine("These circles do not intersect");
        }

        private static Circle MakeCircle()
        {
            Point point = new Point();
            int x, y, radius;
            Console.WriteLine("Enter the coordinates of the centerpoint of the circle.");
            Console.WriteLine("Enter X: ");
            int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Enter Y: ");
            int.TryParse(Console.ReadLine(), out y);
            point.X = x;
            point.Y = y;
            Console.WriteLine("Enter the radius of the circle.");
            Console.WriteLine("Enter radius: ");
            int.TryParse(Console.ReadLine(), out radius);
            return new Circle(point, radius);
        }

        private static int[] parseArray(string numbers) 
        {
            List<int> list = new List<int>();
            int current;
            foreach (char character in numbers)
                if (int.TryParse(character.ToString(), out current)) 
                {
                    list.Add(current);             
                }
            return list.ToArray();
                    
        }

    }
}
