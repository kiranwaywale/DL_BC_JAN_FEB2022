// C# program to illustrate the
// use of null-coalescing operator(??)
using System;

class Program
{

	// Main Method
	static public void Main()
	{

		// a is nullable type
		// and contains null value
		int? a = null;


		// it means if a is null
		// then assign 3 to b
		int b = a ?? 3;

		// It will print 3
		Console.WriteLine(b);
	}
}