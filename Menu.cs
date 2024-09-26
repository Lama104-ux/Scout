class Menu(ScoutRepository repo)
{
    private ScoutRepository _repository = repo;

    public void Run()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Scout Management System!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add a new scout");
            Console.WriteLine("2. List all scouts");
            Console.WriteLine("3. Add new activity");
            Console.WriteLine("4. Edit activity");
            Console.WriteLine("5. List coming activities");
            Console.WriteLine("Q. Exit");

            string input = Console.ReadLine().ToUpper();
            switch (input)
            {
                case "1":
                    AddScout();
                    break;
                case "2":
                    ListScouts();
                    break;
                case "3":
                    AddActivity();
                    break;
                case "4":
                    // Implement edit activity here
                    break;
                case "5":
                    ListActivities();
                    break;
                case "Q":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }
    }

    private void AddScout()
    {
        Console.Clear();
        Console.Write("Enter the scout's name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the scout's date of birth (yyyy-mm-dd): ");
        DateOnly dob = DateOnly.Parse(Console.ReadLine());
        Console.Write("Enter the scout's email: ");
        string email = Console.ReadLine();
        Console.WriteLine("Enter the scout's phone: ");
        string phone = Console.ReadLine();

        Scout scout = new Scout(name, email, phone, dob);
        _repository.AddScout(scout);
    }

    private void ListScouts()
    {
        Console.Clear();
        Console.WriteLine("Scouts:");
        foreach (Scout scout in _repository.GetAllScouts())
        {
            Console.WriteLine($"{scout.Name} - {scout.Email} - {scout.Phone} - {scout.Birthdate}");
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    private void AddActivity()
    {
        Console.Clear();
        Console.Write("Enter the activity name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the activity date (yyyy-mm-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter the activity location: ");
        string location = Console.ReadLine();

        Activity activity = new Activity(name, date, location);
        _repository.AddActivity(activity);
    }

    private void ListActivities()
    {
        Console.Clear();
        Console.WriteLine("Coming activities:");
        foreach (Activity activity in _repository.GetComingActivities())
        {
            Console.WriteLine($"{activity.Name} - {activity.Date} - {activity.Location}");
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}