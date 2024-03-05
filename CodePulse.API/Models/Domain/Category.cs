namespace CodePulse.API.Models.Domain
{
    // This Model will interact with the database directly
    // includes the fields found in the
    // Database: CodePulseDb 
    // Table:   dbo.Categories

    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UrlHandle { get; set; }
    }
}
