using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace WEP.Controllers
{
    public class KiemTraSoNguyenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult<string>> CheckSoNguyen(string numbers)
        {
            var numberList = numbers.Split(',').Select(double.Parse).ToList();
            string requestURL = "https://localhost:7084/api/LAB5_6/Get-check-integer";
            HttpClient client = new HttpClient();

            var requestContent = new StringContent(JsonConvert.SerializeObject(numberList), Encoding.UTF8, "application/json");
            var response = client.PostAsync(requestURL, requestContent).Result;

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                ViewData["result"] = result;
            }
            else
            {
                ViewData["result"] = "Lỗi khi gọi API: " + response.ReasonPhrase;
            }

            return View();
        }
    }
}
