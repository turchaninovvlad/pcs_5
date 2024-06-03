using System.Collections.Generic;

public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string UserId { get; set; }
    public List<Grade> Grades { get; set; }
    public List<Achievement> Achievements { get; set; }
}

public class Grade
{
    public int Id { get; set; }
    public string Semester { get; set; }
    public string Subject { get; set; }
    public string Score { get; set; }
    public int StudentId { get; set; }
}

public class Achievement
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; } 
    public int StudentId { get; set; }
}



public class Teacher
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Subject { get; set; }
    public string Department { get; set; }
}
