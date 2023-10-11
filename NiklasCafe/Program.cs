// See https://aka.ms/new-console-template for more information

using NiklasCafe.Handlers;
using NiklasCafe.Services;

var coffeeService = new CoffeeService();
var milkService = new MilkService();
var sugarService = new SugarService();
var drinkHandler = new DrinkHandler(coffeeService, milkService, sugarService);
Console.WriteLine();


Console.WriteLine(drinkHandler.Drink); //ToString anropas

var butterService = new ButterService();
var cheeseService = new CheeseService();
var tomatoService = new TomatoService();
var sandwichHandler = new SandwichHandler(butterService, cheeseService, tomatoService);


drinkHandler.PrepareDrink();
sandwichHandler.PrepareSandwich();

await Task.WhenAll(drinkHandler.PrepareDrink(), sandwichHandler.PrepareSandwich());

Console.WriteLine(sandwichHandler.Sandwich);
Console.WriteLine(drinkHandler.Drink);

Console.ReadKey();

