﻿using BlogSystem.Models;

public class Comment
{
    public int Id { get; set; }

    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.Now;

  
    public int PostId { get; set; }
    public Post Post { get; set; }

   
    public int UserId { get; set; }
    public User User { get; set; }

  
}
