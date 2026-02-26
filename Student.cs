namespace ConsoleApp;
public class Student
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public List<Cource> EnrolledCources { get; private set; } = new() 

    public Student(int id, string name, List EnrolledCources)
    {
        Id = id;
        Name = name;
    }
    public string GetInfo()
        => $"Id: {Id}, Name: {Name}, EnrolledCources: {EnrolledCources}";
}