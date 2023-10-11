namespace NiklasCafe.Services;

public class SugarService
{
    public event Action SugarAdded;

    public void AddSugar()
    {
        Console.WriteLine("Adding sugar cubes.");
        Thread.Sleep(1000);
        SugarAdded.Invoke();
    }
}