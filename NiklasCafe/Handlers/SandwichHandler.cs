using NiklasCafe.Models;
using NiklasCafe.Services;

namespace NiklasCafe.Handlers;

public class SandwichHandler
{
    private readonly ButterService _butterService;
    private readonly CheeseService _cheeseService;
    private readonly TomatoService _tomatoService;

    public Sandwich Sandwich { get; }

    public SandwichHandler(ButterService butterService, CheeseService cheeseService, TomatoService tomatoService)
    {
        _butterService = butterService;
        _cheeseService = cheeseService;
        _tomatoService = tomatoService;

        Sandwich = new Sandwich();

        _butterService.ButterApplied += ButterServiceOnButterApplied;
        _cheeseService.CheeseAdded += CheeseServiceOnCheeseAdded;
        _tomatoService.TomatoAdded += TomatoServiceOnTomatoAdded;
    }

    private void TomatoServiceOnTomatoAdded(Ingredient tomato)
    {
        Sandwich.Ingredients.Add(tomato);
        Console.WriteLine("Tomato added.");
    }

    private void CheeseServiceOnCheeseAdded(Ingredient cheese)
    {
        Sandwich.Ingredients.Add(cheese);
        Console.WriteLine("Cheese added.");
    }

    private void ButterServiceOnButterApplied(Ingredient butter)
    {
        Sandwich.Ingredients.Add(butter);
        Console.WriteLine("Butter applied.");
    }

    public void PrepareSandwich()
    {
        Console.WriteLine("Making sandwich");
        _butterService.ApplyButter();
        _cheeseService.AddCheese();
        _tomatoService.AddTomato();
    }
}