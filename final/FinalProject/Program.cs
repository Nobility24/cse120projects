class Program
{
    static void Main()
    {
        // Simulating interaction with the program
        var student = new Student
        {
            StudentId = 1,
            Name = "John Doe",
            Age = 16,
            Talents = new List<string> { "Music", "Drawing" },
            Interests = new List<string> { "Technology", "Nature" },
            Subjects = new List<string> { "Math", "Biology" }
        };

        var subjectClass = new SubjectClass
        {
            SubjectId = 101,
            SubjectName = "Mathematics",
            SubjectType = "Sciences"
        };

        var talentClassifier = new TalentClassifier
        {
            TalentsList = new List<string> { "Music", "Drawing" },
            Categories = new List<string> { "Creative", "Analytical", "Social" }
        };

        var interestClassifier = new InterestClassifier
        {
            InterestsList = new List<string> { "Technology", "Nature" },
            Categories = new List<string> { "Technology", "Nature", "Arts" }
        };

        var subjectClassifier = new SubjectClassifier
        {
            SubjectsList = new List<string> { "Math", "Biology" },
            Categories = new List<string> { "Sciences", "Arts" }
        };

        var careerRecommendation = new CareerRecommendation
        {
            TalentsCategory = talentClassifier.CategorizeTalent("Music"),
            InterestsCategory = interestClassifier.CategorizeInterest("Technology"),
            SubjectsCategory = subjectClassifier.CategorizeSubject("Math")
        };

        var careerDatabase = new CareerDatabase
        {
            CareersList = new List<string> { "Software Engineer", "Artist" },
            Requirements = new Dictionary<string, List<string>>
            {
                { "Software Engineer", new List<string> { "Programming Skills", "Problem Solving" } },
                { "Artist", new List<string> { "Creative Skills", "Portfolio" } }
            }
        };

        var careerGuidanceSystem = new CareerGuidanceSystem
        {
            StudentsList = new List<Student> { student },
            CareersDatabase = careerDatabase
        };

        careerGuidanceSystem.AddStudent(student);
        var recommendation = careerGuidanceSystem.GetStudentRecommendation(student);

        Console.WriteLine("Career Recommendation: " + recommendation);
    }
}