using Microsoft.AspNetCore.Mvc;

namespace KFujimuraAllForOneAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniCh1Controller : ControllerBase
{
    [HttpGet]
    [Route("Hello/{name}")]
    //localHost9000/Input/Hello/{name}
    public string SayHello(string name){
        return $"Greetings, {name}. It's nice to meet you!";
    }
}