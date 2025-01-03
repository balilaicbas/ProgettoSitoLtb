namespace WebApplication1.ViewModels
{
    public class CreatePostVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public DateTime? DateTimeCreated { get; set; } = DateTime.Now;
        public string? ApplicationUserId { get; set; }
        public string Image { get; set; }
        public IFormFile? image { get; set; }
    }
}
