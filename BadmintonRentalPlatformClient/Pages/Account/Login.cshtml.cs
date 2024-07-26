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
        
    }
}
