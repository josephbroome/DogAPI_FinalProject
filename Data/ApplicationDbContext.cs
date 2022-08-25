using DogAPI_FinalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DogAPI_FinalProject.Data
{
    public class ApplicationDbContext: IdentityDbContext<AppUser>
    {
    
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options) 
        { 
        
        
        
        }
    
    }
}
