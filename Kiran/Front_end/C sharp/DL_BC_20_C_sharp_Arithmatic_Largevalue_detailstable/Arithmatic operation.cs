using System;
namespace Sample {
   class Demo {
      static void Main(string[] args) {
         int num1 = 10;
         int num2 = 5;
         int result;
         result = num1 + num2;
         Console.WriteLine("Sum Value is {0}", result);
         result = num1 - num2;
         Console.WriteLine("Subtract Value is {0}", result);
         result = num1 * num2;
         Console.WriteLine("Multiple Value is {0}", result);
         result = num1 / num2;
         Console.WriteLine("Division Value is {0}", result);
         result = num1 % num2;
         Console.WriteLine("Mod Value is {0}", result);
         result = num1++;
         Console.WriteLine("Increment Value is {0}", result);
         result = num1--;
         Console.WriteLine("Decrement Value is {0}", result);
         Console.ReadLine();
      }
   }
}