namespace UI;
public class MainMenu : IMenu 
{
    private IBL _bl;

    public MainMenu(IBL bl)
    {
        _bl = bl;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to Restaurant Reviews!");
    }
}
