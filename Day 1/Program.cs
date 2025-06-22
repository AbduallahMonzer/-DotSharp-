using System;
using System.Numerics;

class Person
{
	// Field
	public string name="";
	// or public string ? name;
	// Method
	public void Greet()
	{
		Console.WriteLine($"Hello This The Start of The C# , Hope {name} enjoy");
	}
}
// Variables

class Program
{
	static void Main()
	{
		int a = 2;
		int b = -2834;
		Console.WriteLine(b);
		// int c= 28.22;      wrong not int , you need double or float

		b = 2;
		Console.WriteLine(b);

		double c = 28.22; // right type
		double d = -29.33;
		Console.WriteLine($"c = {c}, d={d}");

		int name1 = a;
		// char name2 = abd;      wrong it should be ="a" only

		string name3 = "abd"; // right type
		Console.WriteLine(name3);

		bool name4 = true;
		Console.WriteLine(name4 ? "go" : "no");
		Console.WriteLine(false ? "go" : "no");

		const int num = 15;
		Console.WriteLine(num);
		// num = 15; error
		// + operator
		string firstName = "Abduallah";
		string secondName = " Monzer";
		string fullName = firstName + secondName;
		Console.WriteLine(fullName);
		//----
		int x = 5, y = 10, z = 15;
		// int x, y, z ;
		//x=y=z=50;
		Console.WriteLine(x + y + z);
		float f1 = 35e3f;
		double d1 = 12E4D;
		Console.WriteLine(f1);
		Console.WriteLine(d1);

		// Calling the any other class from the main
		DataTypes.ShowDataTypes();
		UserInput.InsertData();
		Operator.AllOperators();
		Strings.StringsInfo();
		Person p = new Person();
		p.name = "monzer";
		p.Greet();
		Conditions.Run();
		Loops.WhileFor();
	}
}

class DataTypes
{
	public static void ShowDataTypes()
	{
		// Data types: (int, long), (float, double), (char,string), (bool)
		// Implicit casting (from smaller to bigger)
		int myNumb = 4;
		double myNumb1 = myNumb;
		Console.WriteLine(myNumb);
		Console.WriteLine(myNumb1);
		// Explicit casting (from bigger to smaller)
		double numb2 = 29.2;
		int numb3 = (int)numb2;
		Console.WriteLine(numb2);
		Console.WriteLine(numb3);
		// conversion with built-in method
		int myInt = 10;
		Console.WriteLine(Convert.ToString(myInt));
	}
}

class UserInput
{
	public static void InsertData()
	{
		Console.Write("please Enter Your Name: ");
		string? name = Console.ReadLine();
		Console.WriteLine($"Welcome, {name}!");
		Console.WriteLine("Enter your age:");
		int age = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Your age is: " + age);
	}
}

class Operator
{
	public static void AllOperators()
	{
		// + , - , * , / , % , ++ , -- 
		int a = 10;
		a++;
		Console.WriteLine(a);
		// Assignment operator
		a += 5;
		Console.WriteLine(a);
		// Comparison operator
		int b = 10;
		Console.WriteLine(a == b); // False, because we already incremented the varaible
								   // Logical operator (technical example in problem solving)
								   // && and, || or, ! not.
	}
}

class Strings
{
	public static void StringsInfo()
	{
		// Concatenation
		string myName = "Abduallah";
		myName += " Monzer";
		Console.WriteLine(myName);
		// Interpolation
		string name = "Ali";
		int age = 25;
		Console.WriteLine($"My name is {name} and I am {age} years old.");
		Console.WriteLine(name[2]);
	}
}

class Conditions
{
	public static void Run()
	{
		Iff();
	}
	private static void Iff()
	{
		int x = 23;
		int y = 24;
		if (x > y)
		{
			Console.WriteLine("X is bigger than y");
		}
		else if (x == y)
		{
			Console.WriteLine("x equal y");
		}
		else
		{
			Console.WriteLine("x smaller than y");
		}
		string z = (x > y) ? "x is Bigger than  than y" : "x is smaller than y";
		Console.WriteLine(z);
		/// ---------------------------------------------------------------------------
		int day = 6;
		switch (day)
		{
			case 1:
				Console.WriteLine("Saturday");
				break;
			case 2:
				Console.WriteLine("Sunday");
				break;
			case 3:
				Console.WriteLine("Monday");
				break;
			case 4:
				Console.WriteLine("tuesday");
				break;
			default:
				Console.WriteLine("Looking Forward for the weekend");
				break;
		}
	}
}

class Loops
{
	public static void WhileFor()
	{
		int i = 13;
		while (i < 16)
		{
			i++;
			Console.WriteLine(i);
		}
		// watch the difference when you increment
		int x = 13;
		while (x < 16)
		{
			Console.WriteLine(x);
			x++;
		}
	}
	public static void DoWhile()
	{
		int x = 10;
		do
		{
			x++;
		} while (x < 20);
	}
	public static void ForLoop()
	{
		for (int z = 0; z < 4; z++)
		{
			Console.WriteLine(z);
		}
		// Nested Loop
		for (int y = 0; y < 8; y--)
		{
			Console.WriteLine(" Outer: " + y);
			for (int u = 0; u < 20; u++)
			{
				Console.WriteLine(" Inner: " + u);
			}
		}
		//Foreach
		string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
		foreach (string i in cars)
		{
			Console.WriteLine(i);
		}
	}
}

class MyArray
{
	public static void Arrays()
	{
		//string[] cars = new string[4] { "BMW", "Golf", "Seat", "Mercedes" };
		string[] cars = { "BMW", "Golf", "Seat", "Mercedes" };
		//sorting and looping
		Array.Sort(cars);
		foreach (string i in cars)
		{
			Console.WriteLine(i);
		}
	}
	//Loop through array
	public static void LoopArray()
	{
		string[] names = { "Omar", "Hannah", "Ahmed" };
		for (int i = 0; i < names.Length; i++)
		{
			Console.WriteLine(names[i]);
		}
	}
	// Multidieminssionalarray 
	public static void MultiDimArray()
	{
		int[,] myNumber = { { 1, 2, 3 }, { 4, 5, 6 } };
		Console.WriteLine(myNumber[0, 0]);
		for (int i = 0; i < myNumber.GetLength(0); i++)
		{
			for (int j = 0; j < myNumber.GetLength(1); j++) 
			{
				Console.WriteLine(myNumber[i, j]);
			}
		}
	}
}