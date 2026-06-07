using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServerTimeApp.Pages;

public class IndexModel : PageModel
{
    public string ServerTime { get; set; }

    public void OnGet()
    {
        ServerTime = DateTime.Now.ToString("dddd, MMMM dd yyyy  —  hh:mm:ss tt");
    }
}