using System;

namespace be_RandomSquare
{
  class Program
  {
    static void Main(string[] args)
    {
      var randomNumbers = new SquaredRandoms();
      randomNumbers.RemoveOddSquaredNumbers();
    }
  }
}


// # Squared Randoms
   
// ## References
   
// - [Random class](https://msdn.microsoft.com/en-us/library/system.random(v=vs.110).aspx)
   
// ## Instructions
   
// 1.Using the `Random` class, generate a list of 20 random numbers that are in the range of 1-50.

//    ```csharp
//    Random random = new Random();
//    // Create a list
//    // Populate the list
//    ```

// 2.With the resulting List, populate a new List that contains each number squared.
// For example, if the original list is `2, 5, 3, 15`, the final list will be `4, 25, 9, 225`.
// 3. Then remove any number that is odd from the list of squared numbers.














