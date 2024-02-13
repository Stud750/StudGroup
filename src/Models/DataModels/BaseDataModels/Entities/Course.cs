namespace BaseDataModels.Entities;

public class Course : BaseEntity
{
    public IList<Student> Students { get; set; } = new List<Student>();
}