using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PasswordHash { get; set; }

        public string? AvatarUrl { get; set; }

        [Required]
        public string DisplayName { get; set; }

        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
        [Required]
        public int RoleId { get; set; }

        [Required]
        public Boolean IsActive { get; set; }

        public Role Role { get; set; }

        public ICollection<Post> Posts { get; set; }
    }

}
