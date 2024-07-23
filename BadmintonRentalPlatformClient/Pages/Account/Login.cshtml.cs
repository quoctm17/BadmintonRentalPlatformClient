using System.Net;
using System.Text;
using System.Text.Json;
using BadmintonRentalPlatformClient.Configuration;
using DTOs;
using DTOs.Response.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Utilization;

namespace BadmintonRentalPlatformClient.Pages.Account
{
    public class LoginModel : PageModel
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
            var response = client.PostAsync("api/v1/login", content).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            var result = JsonSerializer.Deserialize<Result<LoginResponse>>(responseContent);
            if (result.data != null) 
            {
                SessionHelper.SetObjectAsJson(HttpContext.Session, "username", result.data.FullName);
                return RedirectToPage("../Index");
            }
            return RedirectToPage("./Login");
        }
    }
}
