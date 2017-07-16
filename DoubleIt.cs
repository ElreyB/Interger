using System;

class DoubleIt
{
  static void Main()
  {
    Console.WriteLine("Give me a number, and I will double it for you!");
    string stringNumber = Console.ReadLine();

    int yourNumber = int.Parse(stringNumber);
    int yourDoubleNumber = yourNumber * 2;

    string stringDoubledNumber = yourDoubleNumber.ToString();

    Console.WriteLine("I double your nubmer for you: " + stringDoubledNumber);
  }
}
