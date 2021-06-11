using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0

            var i = 0;

            // Create a do-while loop and use the template below:
            do
            {
                i++;   // Increment num by 1
                var num = 100;
                // Then add num to the collection - numbers
                // Hint: reference num inside of the Add method's parentheses
                numbers.Add(num);

            } while (i < 100); // <---- While your variable is less than 100



            // Create a while loop
            while (i < 200) ;           // <--- While num is less than 200
            {
                i++;  // Increment num by 1
                var num = 200;  // Then add num to the collection numbers
                                //HINT: copy how this was done in the do while loop
                numbers.Add(num);
            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            // Create a foreach loop using the collection - numbers
            //In the scope of the foreach loop, print each number in numbers
            //var
            //numbers = int.TryParse[] { "1", "2", "3", "4", "5", };
            //foreach(new string anwser in numbers)
            //{
            //    Console.WriteLine($"{}");
            //    Console.WriteLine("Decrease:");                    attempt 1 
            //}    
            //var Numbers = int.Parse[]{ "1", "2", "3",};
            //foreach(var orderNumbers in Numbers)
            //{
            //    Console.WriteLine(orderNumbers);                   attempt 2
            //    Console.WriteLine("Decrease:");
            //}

            var Numbers = new string[] { "one", "two", "three", };
            foreach(var wroteNumbers in Numbers)                          //attempt 3
            {
                Console.WriteLine(wroteNumbers);
                Console.WriteLine("Decrease:");
            }

            


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
                // in your initializer set the value of i to 199
                // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
                // AND as long as i is greater than or equal to 0
                // Decrement i by 1

            //start for loop here
            for(int i=199; i>=0; i-- )    //it seems as if I have (i) initialized as somthing else along with (numbers)
            {
                Console.WriteLine(i); // place numbers[i] inside of the Console.WriteLine() method
            }

            //------------End of exercise
        }
    }
}
