
// See https://aka.ms/new-console-template for more information

using NiklasCafe.Handlers;
using NiklasCafe.Services;

var coffeeService = new CoffeeService();
var milkService = new MilkService();
var sugarService = new SugarService();
var drinkHandler = new DrinkHandler(coffeeService, milkService, sugarService);

coffeeService.PrepareCoffee();
sugarService.AddSugar();
milkService.AddMilk();

Console.WriteLine(drinkHandler.Drink.ToString());