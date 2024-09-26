public class Activity
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public List<Scout> Participants { get; private set; } = []; //En tom lista
    public string Notes { get; set; } = string.Empty; //En tom sträng, samma som "" fast tydligare

    public Activity(string name, DateTime date, string location)
    {
        Name = name;
        Date = date;
        Location = location;
    }

    public void AddParticipant(Scout scout)
    {
        Participants.Add(scout);
    }
}
