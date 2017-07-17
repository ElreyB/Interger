using System;

class SubtractTwoNumbers
{
  static void Main()
  {
    Console.WriteLine("==========Subtraction==========");
    Console.WriteLine("Give me two numbers to Subtract together.");
    Console.WriteLine("First number is: ");
    string stringFirstNumberSubtract = Console.ReadLine();
    Console.WriteLine("Second number is: ");
    string stringSecondNumberSubtract = Console.ReadLine();

    int intFirstNumberSubtract = int.Parse(stringFirstNumberSubtract);
    int intSecondNumberSubtract = int.Parse(stringSecondNumberSubtract);
    int intDifferenceNumber = intFirstNumberSubtract - intSecondNumberSubtract;

    string stringDifferenceNumber = intDifferenceNumber.ToString();

    Console.WriteLine("When you subtract " + stringFirstNumberSubtract + " to " + stringSecondNumberSubtract + ".........");
    Console.WriteLine("You get: " + stringDifferenceNumber + "\n");
  }
}
