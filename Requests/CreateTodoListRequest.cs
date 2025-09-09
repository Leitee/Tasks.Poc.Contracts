namespace Tasks.Poc.Contracts.Requests;

public class CreateTodoListRequest
{
    public required string Title { get; set; }
    public string? Description { get; set; }
}
