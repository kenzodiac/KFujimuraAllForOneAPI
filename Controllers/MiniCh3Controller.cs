using Microsoft.AspNetCore.Mvc;

namespace KFujimuraAllForOneAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniCh3Controller : ControllerBase
{
    [HttpGet]
    [Route("AskingQuestions/{name}/{time}")]

    public string AskingQuestions(string name, string time){
        return $"So you're telling me that your name is \"{name}\", and that you woke up at \"{time}\"? Cool beans!";
    }
}