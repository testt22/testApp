using Microsoft.AspNet.Identity.EntityFramework;

namespace testApp.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("db73668b188e6648bfaab6a2f701222f74Entities")
        {
        }
    }
}