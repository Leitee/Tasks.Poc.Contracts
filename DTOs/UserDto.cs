namespace Tasks.Poc.Contracts.DTOs;

public record UserDto(
    Guid Id,
    string Name,
    string Email,
    DateTime CreatedAt,
    DateTime? LastLoginAt) : IDto;
