using System;

public class Student
{
    public Student(string name, int age, string facultyNumber)
    {
        this.Name = name;
        this.Age = age;
        this.FacultyNumber = facultyNumber;
    }

    public string Name { get; set; }

    public int Age { get; set; }

    public string FacultyNumber { get; set; }

    //public int CompareTo(Student otherStudent)
    //{
    //    if (this.Age!=otherStudent.Age)
    //    {
    //        return this.Age - otherStudent.Age;
    //    }

    //    if (this.Name!=otherStudent.Name)
    //    {
    //        return this.Name.CompareTo(otherStudent.Name);
    //    }

    //    return 0;
    //}
}

