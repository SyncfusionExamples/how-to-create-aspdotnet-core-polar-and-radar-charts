using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mycoreproject.Pages
{
    public class ChartData
    {
        public string Period { get; set; }
        public double Temp { get; set; }
    }
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}
