using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEP.Controllers
{
    public class TinhLaiKepControllers : Controller
    {
        public IActionResult CaculateInterest(int month,long principal,double rate)
        {
            if(month==0 && principal==0 && rate == 0)
            {
                ViewData["result"] = "error";
            }
            else
            {
                string requesURL = $@"https://localhost:7084/api/CaculateInterest/Get-caculateinterest?month={month}&principal={principal}&rate={rate}";
                HttpClient client = new HttpClient();
                var respon = client.GetStringAsync(requesURL).Result;
                ViewData["result"] = respon;
            }
            return View();
        }
       
    }
}
