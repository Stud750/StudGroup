namespace DataModels.Entities;

public abstract class BaseEntity
{
    public Guid Id { get; init; }
    public string Name { get; set; } = null!;
}