using ScoutApp.Core;
namespace ScoutApp.UI;

class ScoutUI
{
    private ScoutRepository _repo;

    public ScoutUI(ScoutRepository repo)
    {
        _repo = repo;
    }

    public void Run()
    {
        while (true)
        {
            Console.Clear();
            PrintMenu();
            MakeChoice(Console.ReadLine().ToUpper());
        }
    }

    private void PrintMenu()
    {
        Console.WriteLine("GÖR DITT VAL:");
        Console.WriteLine("A: Registrera scout");
        Console.WriteLine("B: Visa scoutregister");
        Console.WriteLine("Q: Avsluta");
    }

    private void MakeChoice(string input)
    {
        if (input == "A")
        {
            RegisterScout();
        }
        if (input == "B")
        {
            ShowAllScouts();
        }
        if (input == "Q")
        {
            Environment.Exit(0);
        }
    }

    private void RegisterScout()
    {
        Console.Clear();
        string name = GetString("Ange scoutens namn:");
        string email = GetString("Ange scoutens e-post:");
        _repo.AddScout(new Scout(name, email));
        Console.WriteLine("Scouten är registrerad!");
        Console.ReadKey();
    }

    private void ShowAllScouts()
    {
        Console.Clear();
        Console.WriteLine("ALLA SCOUTER:");
        foreach (var scout in _repo.GetAllScouts())
        {
            Console.WriteLine($"Namn: {scout.Name}, E-post: {scout.Email}");
        }
        Console.ReadKey();
    }

    private string GetString(string prompt = "")
    {
        do
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            Console.WriteLine("Du måste ange något!");
        } while (true);
    }
}