class Student : Person
{
    private int StudentID;
    private List<string> CurrentSubjects = new List<string>();

    public void SetStudentID(int id)
    {
        StudentID = id;
    }

    public void AddSubject(string subject)
    {
        CurrentSubjects.Add(subject);
    }
}