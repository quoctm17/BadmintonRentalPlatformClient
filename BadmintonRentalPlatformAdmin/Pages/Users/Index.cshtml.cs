using BadmintonRentalPlatformAdmin.Configuration;
using DTOs;
using DTOs.Response.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Utilization;

namespace BadmintonRentalPlatformAdmin.Pages.Users;

public class Index : PageModel
{
    [BindProperty]
    public List<UserDto> Users { get; set; }

    public async Task<IActionResult> OnGetAsync()
    {
        Users = HttpClientReference.GetHttpClient<Result<List<UserDto>>>(UrlExtension.URL + "api/v1/users").Data!;
        return Page();
    }
}