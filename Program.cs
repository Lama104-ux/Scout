//Skapa vårt repository där vi lagrar alla scouter och aktiviteter
ScoutRepository repository = new();

//Nu kommer vi låtsas att vi har en applikation där vi kan lägga till scouter och aktiviteter
//samt lista alla tidigare aktiviteter och skicka påminnelser till deltagarna om kommande aktiviteter

//Skapa några nya scouter
Scout scoutOne = new("Kalle", "kalle@scouterna.se", "070-1234567", new DateOnly(2005, 1, 1));
Scout scoutTwo = new("Lisa", "lisa@scouterna.se", "070-7654321", new DateOnly(2006, 2, 2));
Scout scoutThree = new("Pelle", "pelle@scouterna.se", "070-1111111", new DateOnly(2007, 3, 3));

//Lägg till scouterna i vårt repository
repository.AddScout(scoutOne);
repository.AddScout(scoutTwo);
repository.AddScout(scoutThree);

//Skapa en ny aktivitet och lägg den i vårt repository
Activity activityOne = new("Läger", new DateTime(2021, 6, 1, 14, 0, 0), "Skogen");
repository.AddActivity(activityOne);

repository.SendReminder(activityOne);

//Låtsas att aktiviteten nu varit och att vi vill lägga till vilka deltagare som var med och lite anteckningar
//Lägg till scouter i aktiviteten
activityOne.AddParticipant(scoutOne);
activityOne.AddParticipant(scoutTwo);
activityOne.AddParticipant(scoutThree);

activityOne.Notes = "Så trevligt vi hade det!";

//Hämta alla tidigare aktiviteter
List<Activity> pastActivities = repository.GetPastActivities();

//Skriv ut alla tidigare aktiviteter
Console.WriteLine("Tidigare aktiviteter:");
foreach (var activity in pastActivities)
{
    Console.WriteLine($"{activity.Name} - {activity.Date} - {activity.Location}");
    Console.WriteLine($"Anteckningar: {activity.Notes}");
    Console.WriteLine($"Deltagare: ");
    foreach (var scout in activity.Participants)
    {
        Console.Write($"{scout.Name}, ");
    }
}