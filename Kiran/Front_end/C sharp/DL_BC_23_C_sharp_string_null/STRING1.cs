// C# program to declare string using
// string, String and System.String
// and initialization of string
using System;
class StringApplication
{
	// Main Method
	static void Main(string[] args)
	{
		// declare a string Name using
		// "System.String" class
		System.String Name;
		// initialization of String
		Name = "KIRAN";
		// declare a string id using
		// using an alias(shorthand)
		// "String" of System.String
		// class
		String id;
		// initialization of String
		id = "0401";
		// declare a string mrk using
		// string keyword
		string mrk;
		// initialization of String
		mrk = "90";
		// Declaration and initialization of
		// the string in a single line
		string rank = "2";
		// Displaying Result
		Console.WriteLine("Name: {0}", Name);
		Console.WriteLine("Id: {0}", id);
		Console.WriteLine("Marks: {0}", mrk);
		Console.WriteLine("Rank: {0}", rank);
	}
}
