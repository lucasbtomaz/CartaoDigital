using Microsoft.AspNetCore.Mvc;

namespace CartaoDigital.Controllers
{
    // Atributos da Classe
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("calculate")]
        public string Calculate(string operation, double value1, double value2)
        {
            var alert = "Tome cuidado com números negativos";
            var result = $"Resultado da {operation}: ";

            switch (operation)
            {
                case "soma":
                    result += Sum(value1, value2).ToString();
                    break;
                case "subtracao":
                case "subtração":
                    var substractResult = Subtract(value1, value2);
                    if (substractResult < 0)
                    {
                        result += substractResult.ToString() + " " + alert;
                    }
                    else
                    {
                        result += substractResult.ToString();
                    }
                    break;
                case "multiplicacao":
                case "multiplicação":
                    result += Multiply(value1, value2).ToString();
                    break;
                case "divisao":
                case "divisão":
                    result += Divide(value1, value2).ToString();
                    break;
                default:
                    return $"Operação {operation} não encontrada.";
            }

            return result;
        }

        private double Sum(double value1, double value2)
        {
            var result = value1 + value2;
            return result;
        }

        private double Subtract(double value1, double value2)
        {
            var result = value1 - value2;
            return result;
        }

        private double Multiply(double value1, double value2)
        {
            var result = value1 * value2;
            return result;
        }

        private double Divide(double value1, double value2)
        {
            if (value2 == 0)
            {
                throw new ArgumentException("Division by zero is not allowed");
            }
            var result = value1 / value2;
            return result;
        }
    }
}
