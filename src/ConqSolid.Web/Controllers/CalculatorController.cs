using Microsoft.AspNetCore.Mvc;
using ConqSolid.Common;
using System;
using System.Threading;
using System.Net.Http;
using Newtonsoft.Json;
using ConqSolid.MessageTypes;

namespace ConqSolid.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpPost]
        public ActionResult<Adder> Post([FromBody]CalculatorRequest calculatorRequest)
        {
            CalculatorOperatorBase calculator;

            switch(calculatorRequest.CalculatorOperatorType)
            {
                case CalculatorOperatorTypeEnum.Adder:
                {
                    calculator = new Adder(calculatorRequest.LeftVal, calculatorRequest.RightVal);
                    break;
                }
                case CalculatorOperatorTypeEnum.Substracter:
                {
                    calculator = new Substracter(calculatorRequest.LeftVal, calculatorRequest.RightVal);
                    break;
                }
                default:
                {
                    return BadRequest("Invalid CalculatorOperatorType");
                    break;
                }
            }

            calculator.Calculate();
            return Ok(calculator.Result);
        }
    }
}