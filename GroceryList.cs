using System;

class groceryList
{
  static void Main()
  {
    string[] myGroceryList = {"eggs", "milk", "bread", "bananas", "cereal", "rice"};

    Console.WriteLine("My grocery list:");
    for (int index = 0; index<myGroceryList.Length; index++)
    {
      Console.WriteLine(myGroceryList[index]);
    }
  }
}




//BELOW IS FOREACH LOOPS!!
// class GroceryList
// {
//   static void Main()
//   {
//     string[] myGroceryList = {"eggs", "milk", "bread", "bananas", "cereal", "rice", "yogurt"};
//     int[] groceryListPrices = {3, 6, 4, 2, 4, 4};

//     Console.WriteLine("My grocery list:");
//     foreach (string item in myGroceryList)
//     {
//       Console.WriteLine(item);
//     }

//     int total = 0;
//     foreach (int price in groceryListPrices)
//     {
//       total = total + price;
//     }
//     Console.WriteLine("Your total for this shopping trip will be $" + total);
//   }
// }