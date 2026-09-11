class Course
{
public string courseName;
public int MaxSeats;
public List<Student> students = new List<Student>();

public Course(string name, int seats)
    {
    courseName = name;
    MaxSeats = seats;
    
    }
public void Enroll (Student student)
    {
    if(students.Contains(student))
    {
        System.Console.WriteLine("Denna student finns redan tillagd i kursen");
    }

    else
    {
        // Kollar om kursen är full
    if (students.Count >= MaxSeats)
        {
            // Kursen är full
            System.Console.WriteLine("Kursen är full");
        }
        else       
        {
            // Annars lägg till i listan för studenten(kursen) och för kursen(stundenten)
            students.Add(student);
        }

        }
    }


public void Remove (Student student)
{
    if(!students.Contains(student))
    {
    System.Console.WriteLine("Studenten är inte inlaggd i denna kursen");
    }
    else
    {
        students.Remove(student);
    }
}

public void RollCall()
    {
        
    }

public override string ToString()
    {
        
    }

}