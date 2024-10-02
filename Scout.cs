namespace ScoutApp.Core;

class Scout
{
    public string Name { get; set; }
    public string Email { get; set; }
    public DateOnly DateOfBirth { get; set; }

    public Scout(string name, string email)
    {
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentException("Must give scout name and email!");
        }

        Name = name;
        Email = email;
    }
}