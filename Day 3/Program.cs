using System;

namespace ConstructorBasics;
class Program
{
    static void Main()
    {
        Console.WriteLine("Encapsulation demo:");

        Enemy zombie = new Enemy("");       
        Console.WriteLine($"Id: {zombie.ID}");
        Console.WriteLine($"Name: {zombie.Name}");
        Console.WriteLine($"Health: {zombie.Health}");

        zombie.TakeDamage(30);
        Console.WriteLine($"After damage: {zombie.Health}");

        zombie.Heal(500);
        Console.WriteLine($"After big heal: {zombie.Health}");
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

    public Enemy(string name)
    {
        _id = Guid.NewGuid().ToString();
        _name = string.IsNullOrWhiteSpace(name) ? "Unknown" : name.Trim(); // <-- fixes CS8618
        Health = 100;
        Console.WriteLine("New Enemy is created");
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
