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


            Console.WriteLine("Hejja hejja!!");
            Console.WriteLine("HEJ BEA");
            // gkjthgiuerhiu qrhguhyqog
            Console.WriteLine("HEJ BEA");
            Console.WriteLine("HEJ BEA");
            Console.WriteLine("HEJ BEA");
            Console.WriteLine("HEJ BEA");
            Console.WriteLine("HEJ BEA");
            Console.WriteLine("HEJ BEA");
            Console.WriteLine("HEJ BEA");















            Console.WriteLine("Hej Lama!");
            Console.WriteLine("Hej Laaaaama!");
            Console.WriteLine("Hejjjjjjjjjj jag är hungrig     Beaaaaaaa");

            Console.WriteLine("Jag börjar fatta inte detta nu!");
            Console.WriteLine("Jag börjar fatta detta nu! tror jag iaf");
            PrintMenu();

            // LamaMenu8();
            MakeChoice(Input.GetChar("Kul att du är hääåäääär, Välj: Hej Bea"));
        }
    }

    private void PrintMenu()
    {
        Console.WriteLine("GÖR DITT VAL:");
        Console.WriteLine("A: Registrera scout");
        Console.WriteLine("B: Visa scoutregister");
        Console.WriteLine("C: Skapa aktivitet");
        Console.WriteLine("D: Kommande aktiviteter");
        Console.WriteLine("Q: Avsluta");
    }

    private void MakeChoice(char input)
    {
        switch (input)
        {
            case 'A':
                RegisterScout();
                break;
            case 'B':
                ShowAllScouts();
                break;
            case 'C':
                CreateActivity();
                break;
            case 'D':
                ShowAllActivities();
                break;
            case 'Q':
                Environment.Exit(0);
                break;
        }
    }

    private void ShowAllActivities()
    {
        Console.Clear();
        Console.WriteLine("KOMMANDE AKTIVITETER:");
        foreach (var activity in _repo.GetUpcomingActivities())
        {
            Console.WriteLine(activity.Info);
        }
        Console.ReadKey();
    }

    private void CreateActivity()
    {
        Console.Clear();
        string name = Input.GetString("Ange aktivitetens namn: ");
        DateTime date = Input.GetDateTime("Ange datum för aktiviteten: ");
        _repo.AddActivity(new Activity(name, date));
        Console.WriteLine("Aktiviteten är skapad!");
        Console.ReadKey();
    }

    private void RegisterScout()
    {
        Console.Clear();
        string name = Input.GetString("Namn: ");
        string email = Input.GetEmail("E-post: ");
        DateOnly dob = Input.GetDateOnly("Födelsedatum: ");
        _repo.AddScout(name, email, dob);
        Console.WriteLine("Scouten är registrerad!");
        Console.ReadKey();
    }

    private void ShowAllScouts()
    {
        Console.Clear();
        Console.WriteLine("ALLA SCOUTER:");
        foreach (var scout in _repo.GetAllScouts())
        {
            Console.WriteLine($"Namn: {scout.Name}, E-post: {scout.Email}, Ålder: {scout.Age}");
        }
        Console.ReadKey();
    }
}



