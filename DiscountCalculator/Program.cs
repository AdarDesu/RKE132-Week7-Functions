// If price is < 10, then discount is 1%
// If price is >= 10 && < 20, then discount is 5%
// If price is >= 20, then discount is 10%

// Static void (deletes data after usage) / int (number) / string (words) / double (reusable data)...

// Asking the user

Console.WriteLine("Enter your total price:");
int UserInput = Int32.Parse(Console.ReadLine());

// Data from static double

double Discount = CalculatedDiscount(UserInput);
Console.WriteLine($"Your discount is: {Discount}%");

//// Getting the new total price after the discount

//// Method 1

//double NewTotal = UserInput - ((UserInput * Discount) / 100);
//Console.WriteLine($"Your new total price after the {Discount}% discount is: {NewTotal} Euros");

//// Method 2

double NewTotal = CalculateNewTotal(UserInput, Discount);
Console.WriteLine($"Your new total price after the {Discount}% discount is: {NewTotal} Euros");

// Functions

static double CalculatedDiscount( int Total )
{
    if (Total < 10)
    {
        return 1;
    }
    else if ( Total >= 10 && Total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double CalculateNewTotal( double Total, double Discount )
{

    // Getting the new total price after the discount

    double Result = Total - ((Total * Discount) / 100);
    return Result;
}