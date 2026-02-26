namespace ConsoleApp;

public class Univercity
{
    private List<Course> _allCources = new();
    private Dictionary<int, Student> _students = new();
    private Queue<Student> _StudentEnrollnmentQueue = new();
    private Stack<string> _history = new();

    public void AddCource(Course course) => _allCources.Add(course);
    public void AddStudent(Student student) => _students.Add(student.Id, student);

    public void EnrollStudent(int studentId, Course course)
    {
        if (_students.TryGetValue(studentId, out var student))
        {
            student.EnrolledCources.Add(course);
            _history.Push($"student {studentId} enrolled course {course.Name}");
        }
    }

    public void GetInQueue(Student student)
    {
        _StudentEnrollnmentQueue.Enqueue(student);
        _history.Push($"student {student.Id} enrolled course {student.Name}");
    }

    public void GetNextStudentInQueue(Student student)
    {
        if (_StudentEnrollnmentQueue.Count > 0)
        {
            Student nextStudent = _StudentEnrollnmentQueue.Dequeue();
            nextStudent.EnrolledCources.Add(cource);
            _history.Push($"student {nextStudent.Id} enrolled course {nextStudent.Name}");
        }
    }
    public void ShowAllCources()
    {
        foreach (var course in _allCources)
            Console.WriteLine(course.GetInfo());
    }

    public void ShowHistory()
    {
        while (_history.Count > 0)
            Console.WriteLine(_history.Pop());
    }
}