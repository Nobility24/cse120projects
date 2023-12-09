class InterestClassifier : Classifier
{
    private List<string> Interests = new List<string>();

    public void AddInterest(string interest)
    {
        Interests.Add(interest);
    }
}

class SubjectClassifier : Classifier
{
    private List<string> Subjects = new List<string>();

    public void AddSubject(string subject)
    {
        Subjects.Add(subject);
    }
}