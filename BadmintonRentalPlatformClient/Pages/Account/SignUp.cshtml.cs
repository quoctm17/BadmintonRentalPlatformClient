using System.Text;
using System.Text.Json;
using BadmintonRentalPlatformClient.Configuration;
using DTOs;
using DTOs.Request.Authentication;
using DTOs.Response.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BadmintonRentalPlatformClient.Pages.Account;

public class SignUp : PageModel
{
    [BindProperty]
    public RegisterRequest Request { get; set; }

    public async Task<IActionResult> OnGetAsync()
    {
        ViewData["Gender"] = new SelectList(new List<string>()
        {
            "Male",
            "Female"
        });
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        var client = new HttpClient();
        client.BaseAddress = new Uri("https://localhost:7020/");
        var json = JsonSerializer.Serialize(Request);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = client.PostAsync("api/v1/register", content).Result;
        var responseContent = response.Content.ReadAsStringAsync().Result;
        var result = JsonSerializer.Deserialize<Result<RegisterResponse>>(responseContent);
        if (result.data != null) 
        {
            SessionHelper.SetObjectAsJson(HttpContext.Session, "username", result.data.fullName);
            // Return a script to set the token in sessionStorage
            var script = $"<script>sessionStorage.setItem('user', '{result.data.fullName}'); window.location.href = '/Index';</script>";
            return Content(script, "text/html");
        }   
        return RedirectToPage("./SignUp");
    }
}