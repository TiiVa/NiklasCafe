namespace NiklasCafe.Services;

public class MilkService
{
    public event Action MilkAdded;

    public void AddMilk()
    {
        Console.WriteLine("Pouring milk");
        Thread.Sleep(2000);
        MilkAdded.Invoke();
    }
}