using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogAPI_FinalProject.Models
{
    public class AppUser : IdentityUser
    {
        public string? NickName { get; set; }    
        public string Email { get; set; }
        
        //public string NickName { get; set; }
        [NotMapped]
        public string? RoleId { get; set; }
        [NotMapped]
        public string? Role { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem>? RoleList { get; set; }


    }
}
