using System;

class DivideTwoNumbers
{
  static void Main()
  {
    Console.WriteLine("==========Division==========");
    Console.WriteLine("Give me two numbers to divide.");
    Console.WriteLine("First number is: ");
    string stringFirstNumberDivide = Console.ReadLine();
    Console.WriteLine("Second number is: ");
    string stringSecondNumberDivide = Console.ReadLine();

    int intFirstNumberDivide = int.Parse(stringFirstNumberDivide);
    int intSecondNumberDivide = int.Parse(stringSecondNumberDivide);
    int intQuotientNumber = intFirstNumberDivide / intSecondNumberDivide;

    string stringQuotientNumber = intQuotientNumber.ToString();

    Console.WriteLine("When you divide " + stringFirstNumberDivide + " to " + stringSecondNumberDivide + ".........");
    Console.WriteLine("You get: " + stringQuotientNumber);
  }
}
