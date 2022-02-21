// C# program for an array of strings
using System;
class StringAPP
{
	// Main Method
	static void Main(string[] args)
	{
		String[] str_arr = new String[3];
		// Initialising the array of strings
		str_arr[0] = "HTML";
		str_arr[1] = "CSS";
		str_arr[2] = "JS";
		// printing String array
		for (int i = 0; i < 3; i++)
		{
			Console.WriteLine("value at Index position " + i + " is " + str_arr[i]);
		}
	}
}
