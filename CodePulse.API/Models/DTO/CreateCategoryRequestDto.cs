namespace CodePulse.API.Models.DTO
{
    // This Model will interact with the User's Interface
    // for the creation of a new Category
    // includes the fields found in the
    // Database: CodePulseDb 
    // Table:   dbo.Categories

    public class CreateCategoryRequestDto
    {
        public string Name { get; set; }
        public string UrlHandle { get; set; }
    }
}
