class Course
{
public string courseName;
public int MaxSeats;
public List<Student> students = new List<Student>();

// Konstruktorn
public Course(string name, int seats)
    {
    courseName = name;
    MaxSeats = seats;
    
    }
public void Enroll (Student student)
    {
    // Kollar om stundenten redan är tillagd i kursen
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
            student.AddCourse(this);

        }

        }
    }


public void Remove (Student student)
{
    // Kollar om stundenten INTE finns inlaggd på kursen
    if(!students.Contains(student))
    {
    System.Console.WriteLine("Studenten är inte inlaggd i denna kursen");
    }
    else
    {
        // Om den finns så tas den bort på båda hållen!
        students.Remove(student);
        student.Leave(this);
    }
}

// Upprop av stundenter
public void RollCall()
    {
        foreach (Student student in students)
        {
            System.Console.WriteLine(student.studentName);
        }
    }


public override string ToString()
    {
        // Visar status för utbildningen förhoppningsvis
        return courseName + " (" + students.Count + "/" + MaxSeats + " platser)";
    }

public void RemoveStudent (Student student)
    {

        students.Remove(student);
    }
}