public class ScoutRepository
{
    private List<Scout> _scouts = [];
    private List<Activity> _activities = [];

    public void AddScout(Scout scout)
    {
        _scouts.Add(scout);
    }

    public List<Scout> GetAllScouts()
    {
        return _scouts;
    }

    public void AddActivity(Activity activity)
    {
        _activities.Add(activity);
    }

    public List<Activity> GetComingActivities()
    {
        List<Activity> comingActivities = [];
        foreach (var activity in _activities)
        {
            if (activity.Date >= DateTime.Now)
            {
                comingActivities.Add(activity);
            }
        }
        return comingActivities;

    }

    public List<Activity> GetPastActivities()
    {
        List<Activity> pastActivities = [];
        foreach (var activity in _activities)
        {
            if (activity.Date < DateTime.Now)
            {
                pastActivities.Add(activity);
            }
        }
        return pastActivities;
    }

    //Metod som låtsas skicka email till alla deltagare i en aktivitet. Console.WriteLine hade inte varit här i ett riktigt scenario
    public void SendReminder(Activity activity)
    {
        foreach (var scout in _scouts)
        {
            Console.WriteLine($"Pretending to send reminder to {scout.Name} at {scout.Email} about the activity {activity.Name} on {activity.Date}");
        }
    }
}