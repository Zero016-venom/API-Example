using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lap5_6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LAB5_6 : ControllerBase
    {
        [HttpGet("Get-caculate-interest")]
        public double TinhLaiKepTheoThang(int month, long moneyBefore, double yearRate)
        {
            double monthlyRate = yearRate / (100 / 12);
            //int n = 12;
            //double t = month / 12.0;
            double moneyAfter = moneyBefore * Math.Pow((1 + monthlyRate), month);
            return moneyAfter;
        }

        [HttpPost("Get-check-integer")]
        public string CheckSoNguyen(List<double> number)
        {
            List<double> primeNumbers = new List<double>();

            foreach (double num in number)
            {
                if (IsPrime(num))
                {
                    primeNumbers.Add(num);
                }
            }

            if (primeNumbers.Count == 0)
            {
                return "Không có số nguyên tố nào trong danh sách.";
            }

            string result = "Các số nguyên tố trong danh sách là: ";
            result += string.Join(", ", primeNumbers);

            return result;
        }

        [HttpGet("Get-is-Prime")]
        public bool IsPrime(double number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        [HttpGet("Get-phuong-trinh-bac-hai")]
        public string GiaiPhuongTrinhBacHai(double a, double b, double c)
        {
            double delta = (b * b) - (4 * a * c);
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return $"Phương trình có 2 nghiệm X1:  {x1}  và X2:  {x2}";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                return $"Phương trình có nghiệm kép X1 = X2 = {x}";
            }
            else
            {
                return "Phương trình vô nghiệm";
            }

        }

        [HttpGet("Get-tam-giac")]
        public string TinhDienTichTamgiac(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                double P = (a + b + c) / 2;
                double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
                //S = 1/4 * Math.sqrt((a + b + c) * (a + b - c) * (b + c - a) * (c + a - b));
                return $"Diện tích của tam giác là: {S}";
            }
            return $"Các cạnh đã nhập không tạo thành một tam giác hợp lệ.";
        }
    }
}
