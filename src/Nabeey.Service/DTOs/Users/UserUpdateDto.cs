﻿using Nabeey.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Nabeey.Service.DTOs.Users;

public class UserUpdateDto
{
    public long Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    [Required, StringLength(100, MinimumLength = 6)]
    public string Password { get; set; } = string.Empty;
}
