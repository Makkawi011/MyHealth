﻿
using System.ComponentModel.DataAnnotations;

namespace MyHealth.Domain.DTOs;

public class ApplicationUserDTO
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; } 
    public string? Password { get; set; }
    public Picture? ProfilePicture { get; set; }
    public Gender Gender { get; set; }
}
public enum Gender
{
    Mail,
    Femail
}