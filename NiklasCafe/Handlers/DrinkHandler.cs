using NiklasCafe.Models;
using NiklasCafe.Services;

namespace NiklasCafe.Handlers;

public class DrinkHandler
{
    private readonly CoffeeService _coffeeService;
    private readonly MilkService _milkService;
    private readonly SugarService _sugarService;

    public Drink Drink { get; }

    public DrinkHandler(CoffeeService coffeeService, MilkService milkService, SugarService sugarService)
    {
        _coffeeService = coffeeService;
        _milkService = milkService;
        _sugarService = sugarService;

        Drink = new Drink();

        _coffeeService.CoffeeDone += CoffeeServiceOnCoffeeDone;
        _milkService.MilkAdded += MilkServiceOnMilkAdded;
        _sugarService.SugarAdded += SugarServiceOnSugarAdded;
    }

    private void SugarServiceOnSugarAdded()
    {
        Console.WriteLine("Sugar added");
    }

    private void MilkServiceOnMilkAdded()
    {
        Console.WriteLine("Milk added");
    }

    private void CoffeeServiceOnCoffeeDone(Ingredient coffee)
    {
        Drink.Ingredients.Add(coffee);
        Console.WriteLine("Coffee is Done");
    }
}