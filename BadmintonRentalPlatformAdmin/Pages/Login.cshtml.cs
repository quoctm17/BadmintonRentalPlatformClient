using System.Net;
using System.Text;
using System.Text.Json;
using BadmintonRentalPlatformAdmin.Configuration;
using DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Utilization;
using SessionHelper = BadmintonRentalPlatformAdmin.Configuration.SessionHelper;

namespace BadmintonRentalPlatformAdmin.Pages;

public class Login : PageModel
{
    [BindProperty]
    public string Email { get; set; }
    [BindProperty]
    public string Password { get; set; }

    public async Task<IActionResult> OnPostAsync()
    {
        var client = new HttpClient();
        client.BaseAddress = new Uri("https://localhost:7020/");
        var json = JsonSerializer.Serialize(new
        {
            email = Email,
            password = Password
        });
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = client.PostAsync("api/v1/login-admin", content).Result;
        var responseContent = response.Content.ReadAsStringAsync().Result;
        var result = JsonSerializer.Deserialize<Result<string>>(responseContent);
        if (result.statusCode == HttpStatusCode.OK) 
        {
            SessionHelper.SetObjectAsJson(HttpContext.Session, "isLogin", true);
            return RedirectToPage("./Index");
        }
        return RedirectToPage("./Login");
    }
}