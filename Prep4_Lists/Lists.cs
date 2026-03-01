using System;
using System.Collections.Generic;
using System.Linq;
class Lists
{
    static void Main(string[] args)
    {
        string response;

        do
        {
            int input_count = 0;
            int sum = 0;
            int current_number=-1;
            int largest_number=int.MinValue;
            int smallest_number=int.MaxValue;
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

            while (current_number!=0)
            {
                Console.Write("Enter number: ");
                string user_input = Console.ReadLine();
                current_number = int.Parse(user_input);

                if (current_number != 0)
                {
                    input_count++;
                    sum += current_number;
                    numbers.Add(current_number);
                    if (largest_number < current_number)
                    {
                        largest_number = current_number;
                    } 
                    if (current_number > 0 && current_number < smallest_number)
                    {
                        smallest_number = current_number;
                    }
                }
            }
            float average=-1;

            if (input_count > 0)
            {
                average = (float) sum/input_count;
            }

            Console.WriteLine($"The sum is : {sum}");
            Console.WriteLine($"The average is:  {average}");
            Console.WriteLine($"The largest number is:  {largest_number}");
            Console.WriteLine($"The smallest number is:  {smallest_number}");
            Console.WriteLine("The sorted list is:");

            numbers.Sort();
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.Write("Do you want to continue? ");
            response = Console.ReadLine().ToLower();  
        } while (response == "yes");
    }
}


/* Outcome
 Enter a list of numbers, type 0 when finished.
  Enter number: 18
  Enter number: 36
  Enter number: 2
  Enter number: 48
  Enter number: 6
  Enter number: 12
  Enter number: 9
  Enter number: 0
  The sum is: 131
  The average is: 18.714285714285715
  The largest number is: 48
*/
  