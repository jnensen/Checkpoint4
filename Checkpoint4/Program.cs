using System;
using System.Linq;

namespace Checkpoint4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            Console.WriteLine("Best movies ever!");

            string[] movieList = new string[5];

            movieList[0] = "Battle of Justice";

           
            for (int i = 0; i < movieList.Length - 1; i++)
            {
               if (movieList[i] != "null")
                    Console.WriteLine(movieList[i]);
            }


        }
    }
}
