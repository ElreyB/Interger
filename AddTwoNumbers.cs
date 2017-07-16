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

    int yourFirstNumberAdd = int.Parse(stringFirstNumberAdd);
    int yourSecondNumberAdd = int.Parse(stringSecondNumberAdd);
    int yourSumNumber = yourFirstNumberAdd + yourSecondNumberAdd;

    string stringSumNumber = yourSumNumber.ToString();

    Console.WriteLine("When you add " + stringFirstNumberAdd + " to " + stringSecondNumberAdd + ".........");
    Console.WriteLine("You get: " + stringSumNumber + "\n");
  }
}
