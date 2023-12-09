class Classifier
{
    protected List<string> Categories = new List<string>();

    public void Categorize()
    {
        // Implementation for generic categorization
    }
}

class TalentClassifier : Classifier
{
    private List<string> Talents = new List<string>();

    public void AddTalent(string talent)
    {
        Talents.Add(talent);
    }
}