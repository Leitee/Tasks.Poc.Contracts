namespace Tasks.Poc.Contracts.Requests;

public class AddTodoItemRequest
{
    public required string Title { get; set; }
    public required string Priority { get; set; }
    public string? Description { get; set; }
    public DateTime? DueDate { get; set; }
}
