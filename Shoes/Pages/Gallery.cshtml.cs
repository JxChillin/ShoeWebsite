using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Shoes.Pages;

public class GalleryModel : PageModel
{
    private readonly ILogger<GalleryModel> _logger;

    public GalleryModel(ILogger<GalleryModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        string title = "Gallery";
        ViewData["Title"] = title;

        string dateTime = DateTime.Now.ToString("d", new CultureInfo("en-US"));
        ViewData["TimeStamp"] = dateTime;

    }
}
