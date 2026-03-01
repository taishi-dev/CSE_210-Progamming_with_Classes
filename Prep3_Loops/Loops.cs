class Askfullname
{
    static void Main(string[] args)
    {
        string response;

        do
        {
            int guess_count = 0;
            int user_guess=-1;
            Random randomGenerator = new Random();
            int random_number = randomGenerator.Next(1, 11);
            while (random_number!=user_guess)
            {
                Console.Write("What is your guess? ");
                string guess_input = Console.ReadLine();
                user_guess = int.Parse(guess_input);
                guess_count++;
                if (random_number > user_guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (random_number < user_guess)
                {
                    Console.WriteLine("Lower");
                } 
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"Magic Number : {random_number}");
            Console.WriteLine($"Guess count : {guess_count}");

            Console.Write("Do you want to continue? ");
            response = Console.ReadLine().ToLower();  
        } while (response == "yes");
    }
}


/* Output
What is the magic number? 6
  What is your guess? 4
  Higher
  

  What is the magic number? 6 
  What is your guess? 7
  Lower
  

  What is the magic number? 6
  What is your guess? 6
  You guessed it!
*/