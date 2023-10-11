namespace NiklasCafe.Models;

public class Sandwich
{
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

    public override string ToString()
    {
        var sandWichDescription = "";

        sandWichDescription += "The sandwich contains:\n";

        foreach (var sandWichIngredient in Ingredients)
        {
            sandWichDescription += $"\t{sandWichIngredient.Name}\n";
        }

        return sandWichDescription;
    }
}