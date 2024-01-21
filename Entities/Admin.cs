namespace WebApi.Entities;

using System.Text.Json.Serialization;

public class Admin
{
    public int Id { get; set; }
    public string? FirstName { get; set; }

    public string? LastName { get; set; }
    
    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? CountryCode { get; set; }

    public string? Company { get; set; }

    public string? RoleInCompany { get; set; }

    [JsonIgnore]
    public string? PasswordHash { get; set; }

}