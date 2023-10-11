// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using NiklasCafe.Handlers;
using NiklasCafe.Services;

var timer = new Stopwatch();
timer.Start();

var coffeeService = new CoffeeService();
var milkService = new MilkService();
var sugarService = new SugarService();
var drinkHandler = new DrinkHandler(coffeeService, milkService, sugarService);


var butterService = new ButterService();
var cheeseService = new CheeseService();
var tomatoService = new TomatoService();
var sandwichHandler = new SandwichHandler(butterService,cheeseService,tomatoService);

//await drinkHandler.PrepareDrink();
//await sandwichHandler.PrepareSandwich();

await Task.WhenAll(drinkHandler.PrepareDrink(), sandwichHandler.PrepareSandwich());

Console.WriteLine(sandwichHandler.Sandwich);
Console.WriteLine(drinkHandler.Drink);
timer.Stop();
Console.WriteLine(timer.Elapsed);