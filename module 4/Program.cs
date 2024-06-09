using System;

Console.WriteLine("Please enter the dividend.");
string number1 = Console.ReadLine();

Console.WriteLine("Please enter the divisor.");
string number2 = Console.ReadLine();

try
{
    int dividend = Convert.ToInt32(number1);
    int divisor = Convert.ToInt32(number2);

    int quotient = dividend/divisor;
    Console.WriteLine(dividend + " divided by " + divisor + " equals " + quotient);
}
catch (FormatException ex)
{
    Console.WriteLine("At least one of the inputs you provided were not numbers");
    Console.WriteLine("Error Message: " + ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("You cannot divide by zero.");
    Console.WriteLine("Error Message: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Something went wrong.");
    Console.WriteLine("Error Message: " + ex.Message);
}


