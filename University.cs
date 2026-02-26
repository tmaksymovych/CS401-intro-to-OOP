namespace ConsoleApp;

public class University
{
    private List<Course> _allCources = new();
    private Dictionary<int, Student> _students = new();
    private Queue<Student> _StudentEnrollnmentQueue = new();
    private Stack<string> _history = new();

    public void AddCourse(Course course) => _allCources.Add(course);
    public void AddStudent(Student student) => _students.Add(student.Id, student);

    public void EnrollStudent(int studentId, Course course)
    {
        if (_students.TryGetValue(studentId, out var student))
        {
            student.EnrolledCources.Add(course);
            _history.Push($"student {studentId}:{student.Name} enrolled course {course.Name}");
        }
    }

    public void GetInQueue(Student student)
    {
        _StudentEnrollnmentQueue.Enqueue(student);
        _history.Push($"student {student.Id}:{student.Name} joined the queue");
    }

    public void GetNextStudentInQueue(Course course)
    {
        if (_StudentEnrollnmentQueue.Count > 0)
        {
            Student nextStudent = _StudentEnrollnmentQueue.Dequeue();
            nextStudent.EnrolledCources.Add(course);
            _history.Push($"student {nextStudent.Id}:{nextStudent.Name} enrolled course {course.Name}");
        }
    }
    public void ShowAllCourses()
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