class Askfullname
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?: ");
        string first_name = Console.ReadLine();
        Console.Write("What is your last name?: ");
        string last_name = Console.ReadLine();
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}




/*
Outcome 
What is your first name? Scott
What is your last name? Burton
Your name is Burton, Scott Burton.

What is your first name? Brigham
What is your last name? Young
Your name is Young, Brigham Young.
*/