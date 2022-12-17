// Question + Input

Console.WriteLine("Are you sleepy? (Yes/No)");

string UserChoice = Console.ReadLine();
UserChoice = UserChoice.ToLower();

// Choice

if (UserChoice == "yes")
{
    PrintSleepy();
}
else if (UserChoice == "no")
{
    PrintHmm();
}
else
{
    PrintWhat();
}

// Print = Print, () = Do something, Calls out the function

// Function / method

static void PrintHmm()
{
    Console.WriteLine("Hmm really...?");
}

static void PrintSleepy()
{
    Console.WriteLine("I know what you feel... x_x");
}

static void PrintWhat()
{
    Console.WriteLine("You must be more exhausted than I thought...");
}