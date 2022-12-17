// Task

Console.WriteLine("Enter the operation (+/-)");

// User choice

char UserOperator = Char.Parse(Console.ReadLine());

// User input ( FirstNum = a, SecondNum = b )

Console.WriteLine("Enter the first number:");
int FirstNum = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int SecondNum = Int32.Parse(Console.ReadLine());

// Decides the action if it substracts or ads

switch (UserOperator)
{
    case '+':
        Addition(FirstNum, SecondNum);
        break;
    case '-':
        Substraction(FirstNum, SecondNum);
        break;
    default:
        Console.WriteLine("You did something wrong.");
        break;
}

// Static voids

static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Substraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}