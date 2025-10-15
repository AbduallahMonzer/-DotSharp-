using System;

namespace ConstructorBasics;
class Program
{
    static void Main()
    {
        Console.WriteLine("============Construcotrs demo============");

        Enemy e1 = new Enemy(); //Default
        Enemy e2 = new Enemy("Zombie"); //Paramterized
        Enemy e3 = new Enemy(e2); // copy
        Enemy boss = Enemy.CreateBoss();
        Console.WriteLine($"Boss Name: {boss.Name}, Health: {boss.Health}");
    }
}

class Enemy
{
    //Creating Fields
    private readonly string _id;
    private string _name;
    private double _health;

    public string ID => _id;

    // Property
    public string Name
    {
        get => _name;
        set => _name = string.IsNullOrWhiteSpace(value) ? "Unknown" : value.Trim();
    }

    public double Health
    {
        get => _health;
        private set
        {
            if (value < 0) _health = 0;
            else if (value > 100) _health = 100;
            else _health = value;
        }
    }

    // Static constructors always execute once before the first object of that class is created.
    static Enemy()
    {
        Console.WriteLine("static constructor called (run once).");
    }

    // Default constructor 
    public Enemy()
    {
        _id = Guid.NewGuid().ToString();
        _name = "Unkown";
        Health = 100;
        Console.WriteLine("Default constructor called");
    }

    // Paramterized constructor
    public Enemy(string name)
    {
        _id = Guid.NewGuid().ToString();
        _name = string.IsNullOrWhiteSpace(name) ? "Unkown" : name.Trim();
        Health = 100;
        Console.WriteLine("Paramterized constructor called");
    }

    // Copy constructor

    public Enemy(Enemy other)
    {
        _id = Guid.NewGuid().ToString();
        _name = other._name;
        Health = other._health;
        Console.WriteLine("copy constructor called");
    }

    // Private constructor 
    private Enemy(string name, double health)
    {
        _id = Guid.NewGuid().ToString();
        _name = name;
        _health = health;
        Console.WriteLine("private constructor called");
    }
    
    // Factory method using the private constructor
    public static Enemy CreateBoss()
	{
        return new Enemy("Boss", 300);
	}
    public void TakeDamage(double amount)
    {
        if (amount <= 0) return;
        Health = Health - amount;
    }

    public void Heal(double amount)
    {
        if (amount <= 0) return;
        Health = Health + amount;
    }
}
