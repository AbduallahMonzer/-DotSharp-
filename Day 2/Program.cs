// Method is a block of code performs specified task and runs when it's only called
// Access modifiers: public - private - protected - internal 
// Modifier : static - abstract - virtual - override - sealed - async
// return type : void - (data type) - Task<T>

using System;
using System.Globalization;

class MethodsDemo
{

	static void Main(string[] args)
	{
		Person personOne = new Person();
		personOne.FirstName = "Abduallah";
		personOne.LastName = "Monzer";
		personOne.BirthDate = DateOnly.ParseExact("22-9-2000", "d-M-yyyy", CultureInfo.InvariantCulture);
		personOne.Country = "Egypt";

		Person personTwo = new Person();
		personTwo.FirstName = "Mohammed";
		personTwo.LastName = "Monzer";
		personTwo.BirthDate = DateOnly.ParseExact("22-9-2000", "d-m-yyyy", CultureInfo.InvariantCulture);
		personTwo.Country = "Egypt";


		Console.WriteLine(personOne.FirstName);
		Console.WriteLine(personTwo.FirstName);


		MyMethod();
		MyParam(25, "monzzz");
		MyParam(24);
		int z = Returnable(5, 3);
		Console.WriteLine(z);

		int number = 5;
		Calculator calc = new Calculator();

		var demo = new MethodsDemo();
		demo.ChangeValue(number);
		Console.WriteLine($"This is outside the method {number}");
		Console.WriteLine(calc.Add(2, 3));
		Console.WriteLine(calc.Add(2, 3, 4));
		optionalParam(7, "Abudallah", 800);
		Console.ReadLine();

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

	//----------------------------------------------
	//----------Overloaded method-------------------

	

	static void optionalParam(int no, string name, int goal, string country = "", string phone = "")
	{
		Console.WriteLine(no);
		Console.WriteLine(name);
		Console.WriteLine(goal);
		Console.WriteLine(country);
		Console.WriteLine(phone);
	}	
}

