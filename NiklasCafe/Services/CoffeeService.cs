using NiklasCafe.Models;

namespace NiklasCafe.Services;

public class CoffeeService
{
    public event Action<Ingredient> CoffeeDone;

    public void PrepareCoffee()
    {
        Console.WriteLine("Coffee is brewing...");
        Thread.Sleep(4000);
        var coffee = new Ingredient() {Name = "Coffee"};
        CoffeeDone.Invoke(coffee);
    }
}