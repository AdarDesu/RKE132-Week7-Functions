// Task + Input
Console.WriteLine("Write something and press enter.");
string Qwerty = Console.ReadLine();

PrintAnyWord(Qwerty); // qwerty - argument

static void PrintAnyWord(string Anything) // Anything - parameter
{
    Anything = Anything.ToUpper();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(Anything);
    }
}