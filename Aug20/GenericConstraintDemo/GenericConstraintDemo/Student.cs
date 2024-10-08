﻿public abstract class Student
{
    public abstract int Marks { get; set; }  
}

public class GraduateStudent : Student
{
    public override int Marks { get; set; }
}

public class PostGraduateStudent : Student
{
    public override int Marks {get; set; }
}

public class MarksPrinter<T> where T : Student
{
    public T stu;
    public void PrintMarks()
    {
        Student temp = (Student)stu;
        Console.WriteLine(temp.Marks);
    }
}