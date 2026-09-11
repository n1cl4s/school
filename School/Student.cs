class Student
{
public string studentName;
public List<Course> currentCourses = new List<Course>();

public Student(string name)
{
    studentName = name;
}

public void Join(Course course)
{
  if (currentCourses.Contains(course))
    {
        System.Console.WriteLine($"{studentName} går redan denna kurs");
    }
    else
    {
            
        if (course.students.Count >= course.MaxSeats)
        {
           System.Console.WriteLine("Kursen är tyvärr full!"); 
        }
        else
        {
            currentCourses.Add(course);
            course.AddStudent(this);
        }
        }
}
public void Leave(Course course)
    {
        if (!currentCourses.Contains(course))
        {
            System.Console.WriteLine($"{studentName} är inte med i kursen");
        }
        else
        {
            currentCourses.Remove(course);
            course.Remove(this);
        }
    }

    public void Schedule()
    {
        foreach (Course course in currentCourses)
        {
            System.Console.WriteLine($"Schema för {studentName}: {course.courseName}");
        }
    }

    public override string ToString()
    {
        return studentName;
    }

    public void AddCourse (Course course)
    {
        currentCourses.Add(course);
    }

}