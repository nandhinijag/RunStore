using System;

namespace Client.Models;

public record class Customer
{
public string Id { get; set; } = Guid.NewGuid().ToString();
public required string FirstName { get; set; }
public required string LastName { get; set; }
public required string Phone { get; set; }
public required string EPost { get; set; }
public string? Address{ get; set; }
}
