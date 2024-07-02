using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PieShop.Pages;

public class CheckoutCompletePage : PageModel
{
    public void OnGet()
    {
        ViewData["CheckoutCompleteMessage"] = "Thanks for your order. You'll soon enjoy our delicious pies!";
    }
}