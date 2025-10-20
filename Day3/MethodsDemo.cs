using System;

namespace MethodsAndExtensionsDemo;

class Calculator
{
	public int Add(int a, int b)
	{
		return a + b;
	}
	public static int Multiply(int a, int b)
	{
		return a * b;
	}
	public double Divide(double a, double b)
	{
		if (b == 0)
		{
			Console.WriteLine("Cannot divide by zer!");
			return 0;
		}
		return a / b;
	}
}

public static class StringExtensions
{
	public static string FirstLetterUpper(this string str)
	{
		if (string.IsNullOrWhiteSpace(str))
			return string.Empty;
		return char.ToUpper(str[0]) + str.Substring(1);
	}
}