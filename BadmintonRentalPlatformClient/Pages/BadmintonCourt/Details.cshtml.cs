using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BadmintonRentalPlatformClient.Pages.BadmintonCourt
{
    public class DetailsModel : PageModel
    {
        public int Id { get; set; }
        public string BadmintonCourtName { get; set; }

        public void OnGet(int id)
        {
            Id = id;
        }
    }
}
