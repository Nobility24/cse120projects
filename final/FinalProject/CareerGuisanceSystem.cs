// CareerGuidanceSystem class
public class CareerGuidanceSystem
{
    // Attributes
    public List<Student> StudentsList { get; set; }
    public CareerDatabase CareersDatabase { get; set; }

    // Methods
    public void AddStudent(Student student)
    {
        StudentsList.Add(student);
    }

    public string GetStudentRecommendation(Student student)
    {
        // Logic to get recommendation for the student
        // ...

        // For simplicity, returning a placeholder recommendation
        return "Student Recommendation";
    }
}