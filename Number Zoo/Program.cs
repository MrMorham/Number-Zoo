using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
You're working in a number zoo, and it seems that one of the numbers has gone missing!

Zoo workers have no idea what number is missing, and are too incompetent to figure it out, so they're hiring you to do it for them.

In case the zoo loses another number, they want your program to work regardless of how many numbers there are in total.

Task:
Write a function that takes a shuffled array of unique numbers from 1 to n with one element missing (which can be any number including n). Return this missing number.

Examples:
Kata.FindNumber(new int[] {1, 3, 4}) => 2
Kata.FindNumber(new int[] {1, 2, 3}) => 4
Kata.FindNumber(new int[] {4, 2, 3}) => 1
*/

namespace Number_Zoo
{
    class Program
    {
        static void Main (string[] args)
        {
            Operations Command = new Operations();

            List<int> Zoo1 = Command.GenerateZoo(10);
            List<int> Zoo2 = Command.GenerateZoo(30);
            List<int> Zoo3 = Command.GenerateZoo(3);
            List<int> Zoo4 = Command.GenerateZoo(2);
            List<int> Zoo5 = Command.GenerateZoo(1);

            Command.PrintZoo(Zoo1);
            Command.PrintZoo(Zoo2);
            Command.PrintZoo(Zoo3);
            Command.PrintZoo(Zoo4);
            Command.PrintZoo(Zoo5);

            Console.ReadLine();
        }
    }
}
