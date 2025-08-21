using System;

namespace ConstructorBasics;
class Program
{
	static void Main()
	{
		Console.WriteLine("Default Constructor");

		Enemy zombie = new Enemy();
		Console.WriteLine(zombie.Health);
		Console.ReadLine();
	}
}

class Enemy
{
	public string Id { get; set; }
	public string EnemyName { get; set; }
	public double Health { get; set; }

	public Enemy()
	{
		Console.WriteLine("New Enemy is created");
		Health = 100;
	}
}