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
        }
        }
}
public void Leave(Course course)
    {
        if (!currentCourses.Contains(course))
        {
            System.Console.WriteLine("Du är inte med i kursen");
        }
        else
        {
            currentCourses.Remove(course);
        }
    }
}