namespace NiklasCafe.Handlers;

public class CoffeeHandler
{
    public event Action CoffeeDone;

    public void PrepareCoffee()
    {
        Console.WriteLine("Coffee is brewing...");
        Thread.Sleep(4000);
        CoffeeDone.Invoke();
    }
}