﻿using System;

class Program
{
	static void Main()
	{
		string myName;
		Console.WriteLine("Please, enter youre name.");
		myName = Console.ReadLine();
		Console.WriteLine("Hello, {0}", myName);
		Console.ReadLine();
	}
}