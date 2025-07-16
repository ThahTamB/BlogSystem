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

        public ICollection<RolePermission> RolePermissions { get; set; }
    }
}
