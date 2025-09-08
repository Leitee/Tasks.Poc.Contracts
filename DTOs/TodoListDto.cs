namespace Tasks.Poc.Contracts.DTOs;

public record TodoListDto(
    Guid Id,
    string Title,
    string? Description,
    Guid OwnerId,
    DateTime CreatedAt,
    DateTime? UpdatedAt,
    int TotalItems,
    int CompletedItems,
    int PendingItems,
    int OverdueItems,
    double CompletionPercentage,
    bool IsCompleted) : IDto;
