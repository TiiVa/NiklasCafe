using NiklasCafe.Models;

namespace NiklasCafe.Services;

public class MilkService
{
    public event Action<Ingredient> MilkAdded;

    public async Task AddMilk()
    {
        Console.WriteLine("Pouring Milk");
        await Task.Delay(2000);
        var milk = new Ingredient() { Name = "Milk" }; // object initializer
        MilkAdded.Invoke(milk);
    }
}