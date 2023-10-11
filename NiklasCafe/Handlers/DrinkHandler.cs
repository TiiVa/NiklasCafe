namespace NiklasCafe.Handlers;

public class DrinkHandler
{
    private readonly CoffeeHandler _coffeeHandler;

    public DrinkHandler(CoffeeHandler coffeeHandler)
    {
        _coffeeHandler = coffeeHandler;

        _coffeeHandler.CoffeeDone += CoffeeHandlerOnCoffeeDone;
    }

    private void CoffeeHandlerOnCoffeeDone()
    {
        Console.WriteLine("Coffee is Done");
    }
}