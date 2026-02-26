namespace ConsoleApp;
public class Student
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public List<Course> EnrolledCources { get; private set; } = new();

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public void Enroll(Course course) => EnrolledCources.Add(course);
    public string GetInfo()
        => $"Id: {Id}, Name: '{Name}', Enrolled Courses : {EnrolledCources}";
}