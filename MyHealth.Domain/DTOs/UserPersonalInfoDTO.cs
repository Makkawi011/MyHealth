﻿namespace MyHealth.Domain.DTOs;

public class UserPersonalInfoDTO
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}