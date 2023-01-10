using Microsoft.AspNetCore.Mvc;

namespace KFujimuraAllForOneAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class Add2NumbersController : ControllerBase
{
    [HttpGet]
    [Route("Add2Numbers/{num1}/{num2}")]
    //localHost9000/Input/Hello/{name}
    public string Add2Numbers(string num1, string num2){
        int sum = Convert.ToInt32(num1) + Convert.ToInt32(num2);

        return $"The sum of {num1} and {num2} is {sum}";
    }
}