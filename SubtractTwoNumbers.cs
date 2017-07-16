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

    int yourFirstNumberSubtract = int.Parse(stringFirstNumberSubtract);
    int yourSecondNumberSubtract = int.Parse(stringSecondNumberSubtract);
    int yourDifferenceNumber = yourFirstNumberSubtract - yourSecondNumberSubtract;

    string stringDifferenceNumber = yourDifferenceNumber.ToString();

    Console.WriteLine("When you subtract " + stringFirstNumberSubtract + " to " + stringSecondNumberSubtract + ".........");
    Console.WriteLine("You get: " + stringDifferenceNumber + "\n");
  }
}
