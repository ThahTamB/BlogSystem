using BlogSystem.Models;

public class Post
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Slug { get; set; }
    public string Content { get; set; }   

    public string? ImageUrl { get; set; }  

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public string Status { get; set; } = "Draft";


    // SEO
    public string MetaTitle { get; set; }
    public string MetaDescription { get; set; }
    public string MetaKeywords { get; set; }


    public int AuthorId { get; set; }   
    public User Author { get; set; }  


    public ICollection<Comment> Comments { get; set; }
    
}
