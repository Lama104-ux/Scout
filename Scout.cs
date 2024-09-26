public class Scout(string name, string email, string phone, DateOnly birthdate)
{
    public string Name { get; set; } = name;
    public string Email { get; set; } = email;
    public string Phone { get; set; } = phone;
    public DateOnly Birthdate { get; set; } = birthdate;
}
