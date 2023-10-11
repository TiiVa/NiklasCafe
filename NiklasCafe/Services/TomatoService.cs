using NiklasCafe.Models;

namespace NiklasCafe.Services;

public class TomatoService
{
    public event Action<Ingredient> TomatoAdded;

    public async Task AddTomato()
    {
        Console.WriteLine("Slicing Tomato.");
        await Task.Delay(2000);
        var tomato = new Ingredient() {Name = "Tomato"};
        TomatoAdded.Invoke(tomato);
    }
}