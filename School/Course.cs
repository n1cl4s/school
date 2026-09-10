class Course
{
public string courseName;
public int MaxSeats;
public List<Student> students;

public Course(string name, int seats)
    {
    courseName = name;
    MaxSeats = seats;
    
    }
public void Enroll (Student student)
    {
    if (students.Count >= MaxSeats)
        {
            System.Console.WriteLine("Kursen är full");
        }
        else
        {
            students.Add(student);
        }
    }

public void Remove (Student student)

    {
        
    }

public void RollCall()
    {
        
    }

public void override string ToString()
    {
        
    }

}