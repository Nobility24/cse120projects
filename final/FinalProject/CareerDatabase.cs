// CareerDatabase class
public class CareerDatabase
{
    // Attributes
    public List<string> CareersList { get; set; }
    public Dictionary<string, List<string>> Requirements { get; set; }

    // Method
    public List<string> GetCareerRequirements(string career)
    {
        // Logic to retrieve career requirements
        // ...

        // For simplicity, returning placeholder requirements
        return new List<string> { "Requirement 1", "Requirement 2" };
    }
}