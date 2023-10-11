using NiklasCafe.Models;

namespace NiklasCafe.Services;

public class CheeseService
{
    public event Action<Ingredient> CheeseAdded;

    public async Task AddCheese()
    {
        Console.WriteLine("Carving cheese.");
        await Task.Delay(5000);
        var cheese = new Ingredient(){Name = "Cheese"};
        CheeseAdded.Invoke(cheese);
    }
}