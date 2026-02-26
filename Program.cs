using ConsoleApp;

// name a university as kse
University kse = new University();

//  created new 3 courses
Course course1 = new Course(1, "Calculus I", "Dr. Smith");
Course course2 = new Course(2, "Object-Oriented Programming", "Prof. Johnson");
Course course3 = new Course(3, "Data Structures", "Dr. Brown");

// add new courses to Courses list
kse.AddCourse(course1);
kse.AddCourse(course2);
kse.AddCourse(course3);

// created new 3 students
Student student1 = new Student(101, "Alice");
Student student2 = new Student(102, "Bob");
Student student3 = new Student(103, "Charlie");

// add new 3 students to the list of students
kse.AddStudent(student1);
kse.AddStudent(student2);
kse.AddStudent(student3);

// add student2 and student3 to Queue 
kse.GetInQueue(student2);
kse.GetInQueue(student3);

// next student added to  course
kse.GetNextStudentInQueue(course2);

// enroll student directly on course
kse.EnrollStudent(101, course1);

//show all courses
kse.ShowAllCourses();

// show all processes history
kse.ShowHistory();
