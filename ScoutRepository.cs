namespace ScoutApp.Core;

class ScoutRepository //Medlemslista
{
    List<Scout> _scouts = new();
    List<Activity> _activities = new();

    public void AddScout(Scout scout)
    {
        //TODO Kolla om scout-objektet är ok innan vi lägger in det
        _scouts.Add(scout);
    }

    public void AddActivity(Activity activity)
    {
        //TODO Kolla om scout-objektet är ok innan vi lägger in det
        _activities.Add(activity);
    }

    //Registerea deltagare till aktivitet
    public void RegisterParticipantToActivity(int scoutId, int activityID)
    {
        _activities[activityID].Participants.Add(_scouts[scoutId]);
    }

    public Activity GetActivityById(int activityID)
    {
        return _activities[activityID];
    }

    public List<Activity> GetAllActivities()
    {
        return _activities;
    }

    public Scout GetScoutById(int scoutId)
    {
        return _scouts[scoutId];
    }

    public List<Scout> GetAllScouts()
    {
        return _scouts;
    }

    //Hämta kommande aktiviteter
    // public List<Activity> GetComingActivities()
    // {

    // }

    //Skicka påminnelser till alla scouter om kommande aktiviteter

    public void SendEmailsToAllScouts()
    {
        foreach (var scout in _scouts)
        {
            Console.WriteLine("Låtsas maila till: " + scout.Email);
        }
    }
}