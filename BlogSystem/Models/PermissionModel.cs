using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BlogSystem.Models
{
    public class Permission
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } 
        public string Code { get; set; } // Unique code for the permission, e.g., "CanEditPosts"

        public ICollection<RolePermission> RolePermissions { get; set; }
    }
}
