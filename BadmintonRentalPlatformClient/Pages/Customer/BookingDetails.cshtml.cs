using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BadmintonRentalPlatformClient.Pages.Customer
{
    public class BookingDetailsModel : PageModel
    {
        public int BookingReservationId { get; set; }

        public void OnGet(int bookingReservationId)
        {
            BookingReservationId = bookingReservationId;
        }
    }
}
