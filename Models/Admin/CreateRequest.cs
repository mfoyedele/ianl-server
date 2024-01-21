namespace WebApi.Models.Admins;

using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class CreateRequest
{
    [Required]
    public string? FirstName { get; set; }

    [Required]
    public string? LastName { get; set; }

    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    [Required]
    public string? PhoneNumber { get; set; }

    [Required]
    public string? CountryCode { get; set; }

    [Required]
    public string? Company { get; set; }

    [Required]
    public string? RoleInCompany { get; set; }

     [Required]
    [MinLength(6)]
    public string? Password { get; set; }

    [Required]
    [Compare("Password")]
    public string? ConfirmPassword { get; set; }
}