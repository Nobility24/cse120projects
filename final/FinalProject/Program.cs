using System;

class Program
{
    static void Main(string[] args)
    {
          // Example usage of the classes
        CareerGuidanceSystem guidanceSystem = new CareerGuidanceSystem();
        Student student1 = new Student();
        student1.SetPersonalDetails("Henry Pindani", 17);
        student1.SetStudentID(123);
        student1.AddSubject("Math");
        student1.AddSubject("Physics");

        Student student2 = new Student();
        student2.SetPersonalDetails("Jared Noel", 18);
        student2.SetStudentID(124);
        student2.AddSubject("Literature");
        student2.AddSubject("History");

        guidanceSystem.AddStudent(student1);
        guidanceSystem.AddStudent(student2);

    }
}