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
        // Är studenten INTE med i kursen kan den inte tas bort, annars tas den bort
        if (!currentCourses.Contains(course))
        {
            System.Console.WriteLine($"\n{studentName} är inte med i kursen och kan därför inte tas bort\n");
        }
        else
        {
            // Här tas den bort på båda hållen!
            currentCourses.Remove(course);
            course.Remove(this);
        }
    }

    public void Schedule()
    {
        // Schema för studenten
        System.Console.WriteLine($"\nSchema för {studentName}");
        foreach (Course course in currentCourses)
        {
        // Blir snyggare upplägg än min förra version
        // - Matte
        // - Idrott
        // När allt var inom foreach-loopen så blev det onödigt mycket repeterande text.
        System.Console.WriteLine($"- {course.courseName}");
        }
        System.Console.WriteLine("");
    }

    // Gör att namnet på studenten visas
    public override string ToString()
    {
        return studentName;
    }

    // Lägger till en kurs på studentens lista
    // Något jag missade innan
    public void AddCourse (Course course)
    {
        currentCourses.Add(course);
    }

}