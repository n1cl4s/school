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
        System.Console.WriteLine($"\n{studentName} går redan denna kurs");
    }
    else
    {
            
        if (course.students.Count >= course.MaxSeats)
        {
           System.Console.WriteLine("\nKursen är tyvärr full!"); 
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
            System.Console.WriteLine($"\n{studentName} är inte med i kursen och kan därför inte tas bort\n");
        }
        else
        {
            currentCourses.Remove(course);
            course.Remove(this);
        }
    }

    public void Schedule()
    {
        System.Console.WriteLine($"\nSchema för {studentName}");
        foreach (Course course in currentCourses)
        {
        System.Console.WriteLine($"- {course.courseName}");
        }
        System.Console.WriteLine("");
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