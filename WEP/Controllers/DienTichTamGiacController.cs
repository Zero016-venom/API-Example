using Microsoft.AspNetCore.Mvc;

namespace WEP.Controllers
{
    public class DienTichTamGiacController : Controller
    {
        public IActionResult TamGiac(double a, double b, double c)
        {
            if (a == 0 && b == 0 && c == 0)
            {
                ViewData["result"] = "dữ liệu không hợp lệ";

            }
            else
            {
                string requestURL = $@"https://localhost:7084/api/LAB5_6/Get-tam-giac?a={a}&b={b}&c={c}";
                HttpClient client = new HttpClient();
                var response = client.GetStringAsync(requestURL).Result;
                ViewData["result"] = response;
            }
            return View();
        }
    }
}
