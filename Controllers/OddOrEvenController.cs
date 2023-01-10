using Microsoft.AspNetCore.Mvc;

namespace KFujimuraAllForOneAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
    [HttpGet]
    [Route("OddOrEven/{num}")]

    public string OddOrEven(string num){
        int validNum = 0;
        bool isNumber = Int32.TryParse(num, out validNum);
        if (isNumber == false){
            return $"Error: Please input a valid integer. \"{num}\" is not valid.";
        } else {
            string oddOrEvenEval = "";
            if (validNum % 2 == 0) {
                oddOrEvenEval = "even";
            } else {
                oddOrEvenEval = "odd";
            }
            return $"\"{num}\" is an \"{oddOrEvenEval}\" number.";
        }
    }
}