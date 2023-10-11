using NiklasCafe.Models;

namespace NiklasCafe.Services;

public class SugarService
{
    public event Action<Ingredient> SugarAdded;

    public void AddSugar()
    {
        Console.WriteLine("Adding sugar cubes.");
        Thread.Sleep(1000);
        var sugar = new Ingredient() {Name = "Sugar"};
        SugarAdded.Invoke(sugar);
    }
}