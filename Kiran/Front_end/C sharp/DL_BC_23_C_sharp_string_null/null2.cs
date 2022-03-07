 // C# program to illustrate the
// use of Nullable type
using System;
class Prog
{
	// Main Method
	static public void Main()
	{
		// a is nullable type
		// and contains null value
		int? a = null;
		// b is nullable type int
		// and behave as a normal int
		int? b = 2345;
		// this will not print
		// anything on console
		Console.WriteLine(a);
		// gives 2345 as output
		Console.WriteLine(b);
	}
}