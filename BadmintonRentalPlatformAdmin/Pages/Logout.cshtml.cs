using BadmintonRentalPlatformAdmin.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BadmintonRentalPlatformAdmin.Pages;

public class Logout : PageModel
{
    public async Task<IActionResult> OnGetAsync()
    {
        SessionHelper.ClearSession(HttpContext.Session);
        return Redirect("/Login");
    }
}