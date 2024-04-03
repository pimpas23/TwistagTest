using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace TwistagTest.Shared.Models;

public class Employee : Entity
{
    [Required]
    [StringLength(50, ErrorMessage = "First name is too long.")]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [StringLength(50, ErrorMessage = "Last name is too long.")]
    public string LastName { get; set; } = string.Empty;

    public DateTime BirthDate { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;

    public DateTime? JoinedDate { get; set; }
    public DateTime? ExitDate { get; set; }
}
