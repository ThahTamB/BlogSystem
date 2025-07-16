using System.ComponentModel.DataAnnotations;

namespace BlogSystem.Models
{
    public class Role
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }

        public ICollection<RolePermission> RolePermissions { get; set; }
    }
}
