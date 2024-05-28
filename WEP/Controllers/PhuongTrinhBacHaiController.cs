using Microsoft.AspNetCore.Mvc;

namespace WEP.Controllers
{
    public class PhuongTrinhBacHaiController : Controller
    {
        public IActionResult GiaiPhuongTrinh(double a, double b, double c)
        {
            string requestURL = $@"https://localhost:7084/api/LAB5_6/Get-phuong-trinh-bac-hai?a={a}&b={b}&c={c}";
            HttpClient client = new HttpClient();
            var response = client.GetStringAsync(requestURL).Result;
            ViewData["result"] = response;

            return View();
        }

    }
}
