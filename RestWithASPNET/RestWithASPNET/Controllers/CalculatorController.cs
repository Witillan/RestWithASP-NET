using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : Controller
    {
        // GET api/calculator/sum/5/5   
        [HttpGet("sum/{firtNumber}/{secundNumber}")]
        public ActionResult Sum(string firstNumber, string secundNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secundNumber))
            {
                var sum = CovertToDecimal(firstNumber) + CovertToDecimal(secundNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        private decimal CovertToDecimal(string number)
        {
            if (decimal.TryParse(number, out decimal decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        private bool IsNumeric(string strNumber)
        {
            bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out double number);
            return isNumber;
        }
    }
}
