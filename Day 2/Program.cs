// Method is a block of code performs specified task and runs when it's only called
// Access modifiers: public - private - protected - internal 
// Modifier : static - abstract - virtual - override - sealed - async
// return type : void - (data type) - Task<T>

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

		int number = 5;
		var demo = new MethodsDemo();
		demo.ChangeValue(number);
		Console.WriteLine($"This is outside the method {number}");
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


	public void ChangeValue(int x)
	{
		x = 99;
		Console.WriteLine($"This is inside the method {x}");
	}

	// pass by vale : is the default method in C# -- Reassigning the parameter doesn’t change the caller’s variable.
	// pass by reference : gets an alias to the original -- Assigning to the parameter does change the caller’s variable.
}
