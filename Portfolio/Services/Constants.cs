using Microsoft.AspNetCore.Mvc.Rendering;

namespace Portfolio.Services;
public class Constants
{
    public static readonly SelectListItem[] CulturasUISoportadas =
    {
        new SelectListItem { Value = "es", Text = "Español" },
        new SelectListItem { Value = "en", Text = "English" },
        new SelectListItem { Value = "fr", Text = "Français" },
    };
}
