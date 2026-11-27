namespace ProductStore.Models;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; } = "";
    public string PasswordHash { get; set; } = "";
    public int Age { get; set; } = 20;
    public string Role { get; set; } = "User";
}
