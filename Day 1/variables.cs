// Variables

using System;
using System.Net.Mail;
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
		// char name2 = abd;      wrong

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