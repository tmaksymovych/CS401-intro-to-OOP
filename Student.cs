namespace Week4;
public class Student
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public list<Student> EnrolledCources = new() { get; private set; }
}