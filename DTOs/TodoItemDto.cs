namespace Tasks.Poc.Contracts.DTOs;

public record TodoItemDto(
    Guid Id,
    string Title,
    string? Description,
    bool IsCompleted,
    string Priority,
    DateTime CreatedAt,
    DateTime? CompletedAt,
    DateTime? DueDate,
    bool IsOverdue) : IDto;
