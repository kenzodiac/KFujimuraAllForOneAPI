//Kenneth Fujimura
using Microsoft.AspNetCore.Mvc;

namespace KFujimuraAllForOneAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniCh7Controller : ControllerBase
{
    [HttpGet]
    [Route("ReverseIt/{input}")]

    public string ReverseIt(string input){
        string output = "";
        for (int i = input.Length -1; i >= 0; i--) {
            output = output + input[i];
        }
        return $"The reverse of \"{input}\" is: \"{output}\"";
    }
}