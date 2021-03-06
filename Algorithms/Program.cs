﻿using System;
using Algorithms.Common;
using Algorithms.Sorting;

namespace Algorithms
{
    class Program
    {
        static BubbleSort bubbleSort { get; set; }

        static void Main(string[] args)
        {
            try
            {
                bool running = true;

                Console.WriteLine(CommonUtils.Dialogue.InitialGreeting);

                do
                {
                    Console.WriteLine("== What is your selection? ==");
                    Console.WriteLine(CommonUtils.Dialogue.MainMenuOptions);

                    var input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                        case "bubble-sort":
                            OpenDialog(Sort.BubbleSort);
                            break;
                        case "0":
                        case "exit":
                            Console.WriteLine("Program Teminating");
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Did not recognize user input.");
                            break;
                    }

                } while (running);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void OpenDialog(Sort type)
        {
            switch (type)
            {
                case Sort.BubbleSort:
                    BubbleSort();
                    break;
                default:
                    break;
            }
        }

        static void BubbleSort()
        {
            bubbleSort = new BubbleSort();

            Console.WriteLine("Running BubbleSort Algorithm");
            Console.WriteLine("");

            bool running = true;

            do
            {
                Console.WriteLine("What is your action?");
                Console.WriteLine("\tisSorted | delete | sort | add | exit\n");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "isSorted":
                        if (bubbleSort.IsSorted())
                            Console.WriteLine("TRUE");
                        break;
                    case "delete":
                    case "sort":
                        Console.WriteLine("Not yet implemented");
                        break;
                    case "add":
                        bubbleSort.Add(Convert.ToInt32(input));
                        break;
                    case "exit":
                        running = false;
                        break;
                    default: break;
                }
            } while (running);

        }

        enum Sort
        {
            BubbleSort
        }
    }
}
