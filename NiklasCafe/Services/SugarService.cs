using NiklasCafe.Models;

namespace NiklasCafe.Services;

public class SugarService
{
    public event Action<Ingredient> SugarAdded;

    public async Task AddSugar()
    {
        Console.WriteLine("Adding sugar");
        await Task.Delay(1000);
        var sugar = new Ingredient() { Name = "Sugar" };
        SugarAdded.Invoke(sugar);
    }
}