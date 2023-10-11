using NiklasCafe.Models;

namespace NiklasCafe.Services;

public class ButterService
{
    public event Action<Ingredient> ButterApplied;

    public async Task ApplyButter()
    {
        Console.WriteLine("Spreading butter");
        await Task.Delay(4000);
        var butter = new Ingredient(){Name = "Butter"};
        ButterApplied.Invoke( butter );
    }
}