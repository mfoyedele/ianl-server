namespace WebApi.Entities;

using System.Text.Json.Serialization;

public class User
{
    public int Id { get; set; }    
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public int? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    
    [JsonIgnore]
    public string? PasswordHash { get; set; }
}