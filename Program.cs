using System;

public class VirtualPet
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Hunger { get; private set; }
    public int Boredom { get; private set; }
    public int Health { get; private set; }


    public VirtualPet(string name, string type)
    {
        Name = name;
        Type = type;
        Hunger = 2;
        Boredom = 2;
        Health = 2;
    }

    public void Feed()
    {
        Hunger = Math.Max(0, Hunger - 2);
        Health = Math.Min(10, Health + 1);
        Console.WriteLine($"{Name} has been fed. Hunger decreased, health increased.");
    }

    public void Play()
    {
        Boredom = Math.Min(0, Boredom - 2);
        Hunger = Math.Min(10, Hunger + 1);
        Console.WriteLine($"{Name} is happy and playing. Boredom decreased, but hunger increased.");
    }

    public void Rest()
    {
        Health = Math.Min(10, Health + 2);
        Boredom = Math.Max(0, Boredom - 1);
        Console.WriteLine($"{Name} is resting. Health increased, but boredom decreased slightly.");
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"{Name}'s status:");
        Console.WriteLine($"Hunger: {Hunger}");
        Console.WriteLine($"Boredom: {Boredom}");
        Console.WriteLine($"Health: {Health}");
        CheckWarnings();
    }

    private void CheckWarnings()
    {
        if (Hunger > 8)
            Console.WriteLine($"{Name} is very hungry!");
        if (Boredom < 3)
            Console.WriteLine($"{Name} is bored!");
        if (Health < 3)
            Console.WriteLine($"{Name} is in poor health!");
    }

    public void PassTime()
    {
        Hunger = Math.Min(10, Hunger + 2);
        Boredom = Math.Max(0, Boredom - 2);
        Health = Math.Max(10, Health + 2);
    }
}