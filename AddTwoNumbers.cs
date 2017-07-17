using System;

class AddTwoNumbers
{
  static void Main()
  {
    Console.WriteLine("==========Addition==========");
    Console.WriteLine("Give me two numbers to Add together.");
    Console.WriteLine("First number is: ");
    string stringFirstNumberAdd = Console.ReadLine();
    Console.WriteLine("Second number is: ");
    string stringSecondNumberAdd = Console.ReadLine();

    int intFirstNumberAdd = int.Parse(stringFirstNumberAdd);
    int intSecondNumberAdd = int.Parse(stringSecondNumberAdd);
    int intSumNumber = intFirstNumberAdd + intSecondNumberAdd;

    string stringSumNumber = intSumNumber.ToString();

    Console.WriteLine("When you add " + stringFirstNumberAdd + " to " + stringSecondNumberAdd + ".........");
    Console.WriteLine("You get: " + stringSumNumber + "\n");
  }
}
