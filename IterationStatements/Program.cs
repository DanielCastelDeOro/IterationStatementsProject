using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            var mynumber = 0;
            do
            {
                mynumber++
                    numbers.Add(mynumber);
            }while(mynumber< 100);

            while (mynumber < 200) ;
            {
                mynumber++;
                numbers.Add(mynumber);
            }
            Console.WriteLine("Increase:");
            
            foreach(var idem in numbers)
            {
                Console.WriteLine(idem);
                Console.WriteLine("Decrease:");
            }
            
            for (int i = 199; i <=numbers.Count && i >=0; i--)
            {
                Console.WriteLine($"{numbers[i]}")
            }
           
        }
    }
}
