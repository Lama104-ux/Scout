ScoutRepository repo = new();

//Fyll på med några scouter och aktiviteter från början (för att vi inte alltid måste lägga in saker för att testa)
repo.AddScout(new Scout("Sam", "sam@scouterna.se", "1234567890", new DateOnly(2004, 1, 1)));
repo.AddScout(new Scout("Kim", "kim@scouterna.se", "1234567890", new DateOnly(2009, 10, 1)));
repo.AddScout(new Scout("Alex", "alex@scouterna.se", "1234567890", new DateOnly(2010, 1, 12)));
repo.AddActivity(new Activity("Hajk", new DateTime(2021, 10, 1, 14, 0, 0), "Vi ska ut och vandra i skogen och tälja en pinne."));

Menu menu = new(repo);
menu.Run();