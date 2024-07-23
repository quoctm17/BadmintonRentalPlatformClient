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
                email = "nguyenho30112003@gmail.com",
                password = "123456"
            });
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync("api/v1/login", content).Result;
            if (response.IsSuccessStatusCode) 
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                var result = JsonSerializer.Deserialize<Result<LoginResponse>>(responseContent);
                SessionHelper.SetObjectAsJson(HttpContext.Session, "username", result.data.fullName);
                // Return a script to set the token in sessionStorage
                var script = $"<script>" +
                                        $"console.log({result.data.fullName});" +
                                        $"sessionStorage.setItem('user', '{result.data.accessToken}'); " + 
                                        "window.location.href = '/Index';"+ 
                                    "</script>";
                return Content(script, "text/html");
            }
            return RedirectToPage("./Login");
        }
    }
}
