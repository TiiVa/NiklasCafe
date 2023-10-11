using NiklasCafe.Models;

namespace NiklasCafe.Services;

public class MilkService
{
    public event Action<Ingredient> MilkAdded;

    public void AddMilk()
    {
        Console.WriteLine("Pouring milk");
        Thread.Sleep(2000);
        var milk = new Ingredient() {Name = "Milk"};
        MilkAdded.Invoke(milk);
    }
}