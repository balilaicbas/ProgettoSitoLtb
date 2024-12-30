
namespace WebApplication1.Models
{
    public class Post
    {
        public int id{ get; set; }
        public string title{ get; set; } 
        public string description{ get; set; }
        public string image{ get; set; }

        public string url { get; set; }
        public DateTime? DateTimeCreated { get; set; }
        public ApplicationUser? ApplicationUser{ get; set; }

    }
}
