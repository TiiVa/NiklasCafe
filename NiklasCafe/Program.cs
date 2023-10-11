// See https://aka.ms/new-console-template for more information

using NiklasCafe.Handlers;

var coffeeHandler = new CoffeeHandler();
var drinkHandler = new DrinkHandler(coffeeHandler);

coffeeHandler.PrepareCoffee();