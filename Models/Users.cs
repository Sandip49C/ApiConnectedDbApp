using SQLite;

namespace ApiConnectedDbApp.Models;

public class User
{
    [PrimaryKey]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    // Add more fields if you want (e.g., Username, Phone), but keep it simple.
}