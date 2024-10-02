using ScoutApp.Core;

ScoutRepository repo = new();

repo.AddScout(new Scout("Sam", "sam@scouterna.se"));

repo.AddActivity(new Activity("Plocka svamp", new DateTime(2024, 10, 14, 12, 0, 0)));

repo.RegisterParticipantToActivity(3, 0);

Activity theActivity = repo.GetActivityById(0);
Console.WriteLine(theActivity.Info);

