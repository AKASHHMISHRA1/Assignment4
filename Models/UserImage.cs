namespace Assignment4.Models
{
    public class UserImage
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public IFormFile image { get; set; } = null!;
    }
}
