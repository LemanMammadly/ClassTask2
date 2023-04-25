public class Group
{
    public string No { get; set; }
    public int Limit { get; set; }
    public Student[] Students { get; private set; }


    public Group(string no, int limit, Student[] students)
    {
        No = no;
        Limit = limit;
        Students = students;
    }

    public string AddStudent(Student student)
    {
        if(Students.Length<Limit)
        {
            return "Yer mövcuddur.";
        }
        else
        {
            return "Yer mövcud deyil.";
        }
    }

    public void GetStudents()
    {
        foreach (Student student in Students)
        {
            Console.WriteLine($"{student.Name} {student.Surname}");
        }
    }
}



