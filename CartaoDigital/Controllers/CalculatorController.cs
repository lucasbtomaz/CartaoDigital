using Microsoft.AspNetCore.Mvc;

namespace CartaoDigital.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet]
        public int GetSoma(int num1, int num2)
        {
            var result = num1 + num2;
            return result;
        }

        [HttpGet("Multiplicacao")]
        public int GetMultiplicacao(int num1, int num2)
        {
            var result = num1 * num2;
            return result;
        }

        [HttpPost]
        public double GetDivisao([FromBody] DivisaoRequest request)
        {
            return request.Divisao();
        }

        public class DivisaoRequest
        {
            public double Num1 { get; set; }
            public double Num2 { get; set; }
            public double Divisao()
            {
                return Num1 / Num2;
            }
        }


    }
}
