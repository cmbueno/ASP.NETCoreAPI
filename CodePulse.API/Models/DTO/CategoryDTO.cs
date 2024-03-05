namespace CodePulse.API.Models.DTO
{
    // This Model will interact with the User's Interface
    // includes the fields found in the
    // Database: CodePulseDb 
    // Table:   dbo.Categories

    public class CategoryDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UrlHandle { get; set; }
    }
}
