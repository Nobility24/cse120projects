using System;
using System.Collections.Generic;

// Base class for Student
public class Student
{
    // Attributes
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Talents { get; set; }
    public List<string> Interests { get; set; }
    public List<string> Subjects { get; set; }

    // Methods
    public void AddTalents(List<string> talents)
    {
        Talents.AddRange(talents);
    }

    public void AddInterests(List<string> interests)
    {
        Interests.AddRange(interests);
    }

    public void AddSubjects(List<string> subjects)
    {
        Subjects.AddRange(subjects);
    }
}