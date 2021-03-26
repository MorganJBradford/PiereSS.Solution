using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PierreSS.Models
{
  public class PierreSSContext : IdentityDbContext<ApplicationUser>
  {

    public PierreSSContext(DbContextOptions options) : base(options) { }

  }
}