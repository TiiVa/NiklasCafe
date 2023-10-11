using NiklasCafe.Models;

namespace NiklasCafe.Services;

public class MilkService
{

    public event Action<Ingredient> MilkAdded;

    public async Task AddMilk()
    {
        Console.WriteLine("Pouring milk");
        await Task.Delay(2000);
        var milk = new Ingredient() {Name = "Milk"};
        MilkAdded.Invoke(milk);
    }
}