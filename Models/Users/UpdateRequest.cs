namespace WebApi.Models.Users;

using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class UpdateRequest
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    

    // treat empty string as null for password fields to 
    // make them optional in front end apps
    private string? _password;
    [MinLength(6)]
    public string? Password
    {
        get => _password;
        set => _password = replaceEmptyWithNull(value);
    }

    private string? _confirmPassword;
    [Compare("Password")]
    public string? ConfirmPassword 
    {
        get => _confirmPassword;
        set => _confirmPassword = replaceEmptyWithNull(value);
    }

    // helpers

    private string? replaceEmptyWithNull(string? value)
    {
        // replace empty string with null to make field optional
        return string.IsNullOrEmpty(value) ? null : value;
    }
}