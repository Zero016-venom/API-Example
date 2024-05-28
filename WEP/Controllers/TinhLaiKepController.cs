using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEP.Controllers
{
    public class TinhLaiKepController : Controller
    {
        public IActionResult LaiKep(int thang, long tienBanDau, double laiSuatThang)
        {
            if (thang == 0 || tienBanDau == 0 || laiSuatThang == 0)
            {
                ViewData["result"] = "error";
            }
            else if (laiSuatThang < 0 || laiSuatThang > 100)
            {
                ViewData["Error1"] = "Lãi suất tháng không hợp lệ. Vui lòng nhập giá trị từ 0 đến 100.";
                return View();
            }
            else if(thang < 0)
            {
                ViewData["Error2"] = "Tháng không hợp lệ. Vui lòng nhập giá trị > 0";
            }
            else if (tienBanDau < 0)
            {
                ViewData["Error3"] = "Số tiền không hợp lệ. Vui lòng nhập giá trị > 0";
            }
            else
            {
                string requestURL = $@"https://localhost:7084/api/LAB5_6/Get-caculate-interest?thang={thang}&tienBanDau={tienBanDau}&laiSuatThang={laiSuatThang}";
                HttpClient client = new HttpClient();
                var response = client.GetStringAsync(requestURL).Result;
                ViewData["result"] = response;
            }
            return View();
        }

    }
}
