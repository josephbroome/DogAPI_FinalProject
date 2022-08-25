
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace DogAPI_FinalProject.Models.ViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }

        public IEnumerable<SelectListItem>? RoleList { get; set; }
        public string? RoleSelected { get; set; }


    }
}
