using System;
using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : Controller
    {
        // GET api/calculator/sum/5/5   
        [HttpGet("sum/{firstNumber}/{secundNumber}")]
        public ActionResult Sum(string firstNumber, string secundNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secundNumber))
            {
                var sum = CovertToDecimal(firstNumber) + CovertToDecimal(secundNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        // GET api/calculator/subtraction/5/5   
        [HttpGet("subtraction/{firstNumber}/{secundNumber}")]
        public ActionResult Subtraction(string firstNumber, string secundNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secundNumber))
            {
                var subtraction = CovertToDecimal(firstNumber) - CovertToDecimal(secundNumber);
                return Ok(subtraction.ToString());
            }
            return BadRequest("Invalid Input");
        }

        // GET api/calculator/division/5/5   
        [HttpGet("division/{firstNumber}/{secundNumber}")]
        public ActionResult Division(string firstNumber, string secundNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secundNumber))
            {
                var division = CovertToDecimal(firstNumber) / CovertToDecimal(secundNumber);
                return Ok(division.ToString());
            }
            return BadRequest("Invalid Input");
        }

        // GET api/calculator/multiplication/5/5   
        [HttpGet("multiplication/{firstNumber}/{secundNumber}")]
        public ActionResult Multiplication(string firstNumber, string secundNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secundNumber))
            {
                var multiplication = CovertToDecimal(firstNumber) * CovertToDecimal(secundNumber);
                return Ok(multiplication.ToString());
            }
            return BadRequest("Invalid Input");
        }

        // GET api/calculator/mean/5/5   
        [HttpGet("mean/{firstNumber}/{secundNumber}")]
        public ActionResult Mean(string firstNumber, string secundNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secundNumber))
            {
                var mean = (CovertToDecimal(firstNumber) + CovertToDecimal(secundNumber)) / 2;
                return Ok(mean.ToString());
            }
            return BadRequest("Invalid Input");
        }

        // GET api/calculator/square-root/5   
        [HttpGet("square-root/{number}")]
        public ActionResult SquareRoot(string number)
        {
            if (IsNumeric(number))
            {
                var squareRoot  = Math.Sqrt((double)CovertToDecimal(number));
                return Ok(squareRoot.ToString());
            }
            return BadRequest("Invalid Input");
        }
        //Convertendo para decimal
        private decimal CovertToDecimal(string number)
        {
            decimal decimalValue;
            if (decimal.TryParse(number, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }
        //Verificando se é numerico
        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNumber;
        }
    }
}
