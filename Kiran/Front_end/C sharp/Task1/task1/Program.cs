// C# program to display the details of the employee's

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
	
namespace Sample
{
	class Demo
	{
		static void Main(string[] args)
		{
			int num1 = 50;
			int num2 = 25;
			int result;
			result = num1 + num2;
			Console.WriteLine("Sum Value is {0}", result);
			result = num1 - num2;
			Console.WriteLine(" Subtract Value is {0}", result);
			result = num1 * num2;
			Console.WriteLine("Multiple Value is {0}", result);
			result = num1 / num2;
			Console.WriteLine("Divisin Value is {0}", result);
			result = num1 % num2;
			Console.WriteLine(" Mod Value is {0}", result);
			result = num1++;
			Console.WriteLine(" Increment Value is {0}", result);
			result = num1--;
			Console.WriteLine("Decrement Value is {0}", result);
			Console.ReadLine();
		}
	}
}