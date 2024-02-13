namespace BaseDataModels.Entities;

public class Student : BaseEntity
{
    public IList<Course> Courses { get; set; } = new List<Course>();
}