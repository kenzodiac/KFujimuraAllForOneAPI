using Microsoft.AspNetCore.Mvc;

namespace KFujimuraAllForOneAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniCh4Controller : ControllerBase
{
    [HttpGet]
    [Route("GreaterThan/{num1}/{num2}")]

    public string GreaterThan(double num1, double num2){
        if (num1 > num2) {
            return $"{num1} is greater than {num2}.";
        } else if (num2 > num1){
            return $"{num1} is less than {num2}.";
        } else {
            return $"{num1} is the same as {num2}";
        }
    }
}