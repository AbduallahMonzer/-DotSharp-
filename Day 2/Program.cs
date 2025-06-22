// Method is a block of code runs when it's only called
using System;
class MethodsDemo
{
	static void Main(string[] args)
	{
		MyMethod();
		MyParam(25, "monzzz");
		MyParam(24);
		int z = Returnable(5, 3);
		Console.WriteLine(z);
	}
	static void MyMethod()
	{
		Console.WriteLine("MyMethod was calling");
	}

	static void MyParam(int age, string fname = "Abduallah")
	{
		Console.WriteLine(fname + " is " + age);
	}
	
	static int Returnable(int x, int y)
	{
		return x + y;
	}

}