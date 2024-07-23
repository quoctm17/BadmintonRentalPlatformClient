using BadmintonRentalPlatformAdmin.Configuration;
using DTOs;
using DTOs.Response.BadmintonCourt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Utilization;

namespace BadmintonRentalPlatformAdmin.Pages.BadmintonCourts;

public class Index : PageModel
{
    
    [BindProperty]
    public List<BadmintonCourtDto> BadmintonCourts { get; set; }

    public async Task<IActionResult> OnGetAsync()
    {
        BadmintonCourts = HttpClientReference.GetHttpClient<Result<List<BadmintonCourtDto>>>(UrlExtension.URL + "api/v1/badminton-courts").data!;
        return Page();
    }
}