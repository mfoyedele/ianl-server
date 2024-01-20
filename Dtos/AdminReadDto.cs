using System.ComponentModel.DataAnnotations;

namespace WebApi.Dtos
{
    public class AdminReadDto
    {
    public int Id { get; set; }
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? CountryCode { get; set; }

    public string? Company { get; set; }

    public string? RoleInCompany { get; set; }

    [MinLength(6)]
    public string? Password { get; set; }

    [Compare("Password")]
    public string? ConfirmPassword { get; set; }
    }

}
