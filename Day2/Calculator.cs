using System;
public class Calculator
{
	public int Add(int a, int b)
	{
		return a + b;
	}

	public int Add(int a, int b, int c)
	{
		return a + b + c;
	} //Here will happen the overload -> the program will search for which method has 3 params
}