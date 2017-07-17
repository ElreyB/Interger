using System;

class MultiplyTwoNumbers
{
  static void Main()
  {
    Console.WriteLine("==========Multiplication==========");
    Console.WriteLine("Give me two numbers to multiply.");
    Console.WriteLine("First number is: ");
    string stringFirstNumberMultiply = Console.ReadLine();
    Console.WriteLine("Second number is: ");
    string stringSecondNumberMultiply = Console.ReadLine();

    int intFirstNumberMultiply = int.Parse(stringFirstNumberMultiply);
    int intSecondNumberMultiply = int.Parse(stringSecondNumberMultiply);
    int intFactorNumber = intFirstNumberMultiply * intSecondNumberMultiply;

    string stringFactorNumber = intFactorNumber.ToString();

    Console.WriteLine("When you multiply " + stringFirstNumberMultiply + " to " + stringSecondNumberMultiply + ".........");
    Console.WriteLine("You get: " + stringFactorNumber);
  }
}
