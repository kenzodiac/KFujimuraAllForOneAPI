using Microsoft.AspNetCore.Mvc;

namespace KFujimuraAllForOneAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{
    [HttpGet]
    [Route("MadLib/{name1}/{verb1}/{sport1}/{musicGenre1}/{pet1}/{petName1}/{name2}/{verb2}/{hobby1}/{musicGenre2}")]

    public string MadLib(string name1, string verb1, string sport1, string musicGenre1, string pet1, string petName1, string name2, string verb2, string hobby1, string musicGenre2){
        return $"This is the story of {name1}. {name1} was a simple person who enjoyed simple things. They liked to {verb1}, play {sport1}, and sing {musicGenre1} in the shower. Life was good. \n\nBut then one day, {name1} met a strange person while walking their {pet1}, {petName1}. Their name was {name2}. They were a new neighbor of {name1}'s and {name1} thought them quite peculiar.\n\nBecause instead of liking to {verb1}, they liked to {verb2} instead. Instead of playing {sport1}, or really any kind of sports, {name2} was an enjoyer of {hobby1}. And instead of {musicGenre1} they liked {musicGenre2}!? \n\n{name1} could not fathom such a bizarre person. \n\nBut that's because {name1} was a person lacking in empathy and had a narrow worldview. So {name1} subconsciously avoided {name2} in order to avoid the terrible cognitive dissonance in his head. Never realizing that {name2} was secretly their long lost sibling! Gasp! How tragic.\n\nThe End.";
    }
}
