namespace PierreSS.Controllers
{
  public class AccountController : Controller
  {
    private readonly PierreSSContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    
  }
}