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
		var PersonOne = new Person
		{
			FirstName = "Abduallah",
			LastName = "Monzer",
			BirthDate = DateOnly.ParseExact("22-9-2000", "d-M-yyyy", CultureInfo.InvariantCulture),
			Country = "Egypt"
		};

		var PersonTwo = new Person
		{
			FirstName = "Mohammed",
			LastName = "Monzer",
			BirthDate = DateOnly.ParseExact("11-11-1998", "d-M-yyyy", CultureInfo.InvariantCulture),
			Country = "Egypt"
		};


		Console.WriteLine(PersonOne.FirstName);
		Console.WriteLine(PersonTwo.FirstName);


		ShowMessage();
		PrintPersonAge(25, "monzzz");
		PrintPersonAge(24); //uses default name

		int result = AddNumbers(5, 3);
		Console.WriteLine(result);

		int number = 5;

		var demo = new MethodsDemo();
		demo.ChangeValue(number);
		Console.WriteLine($"This is outside the method {number}");

		var calc = new Calculator();
		Console.WriteLine(calc.Add(2, 3));
		Console.WriteLine(calc.Add(2, 3, 4));

		PrintOptionalInfo(7, "Abudallah", 800);
	}
	static void ShowMessage()
	{
		Console.WriteLine("MyMethod was calling");
	}

	static void PrintPersonAge(int age, string fname = "Abduallah")
	{
		Console.WriteLine(fname + " is " + age);
	}

	static int AddNumbers(int x, int y) => x + y;


	public void ChangeValue(int x)
	{
		x = 99;
		Console.WriteLine($"This is inside the method {x}");
	}

	// pass by vale : is the default method in C# -- Reassigning the parameter doesn’t change the caller’s variable.
	// pass by reference : gets an alias to the original -- Assigning to the parameter does change the caller’s variable.

	//----------------------------------------------
	//----------Overloaded method-------------------

	

	static void PrintOptionalInfo(int no, string name, int goal, string country = "", string phone = "")
	{
		Console.WriteLine(no);
		Console.WriteLine(name);
		Console.WriteLine(goal);
		Console.WriteLine(country);
		Console.WriteLine(phone);
	}	
}

