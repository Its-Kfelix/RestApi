
using Microsoft.AspNetCore.Mvc;

namespace Rpg3.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController: ControllerBase
{
    private static List<Character> characters = new List<Character>()
    {
        new Character { Id = 0, Name = "David" },
        new Character { Id = 1, Name = "Solomon" },
        new Character { Id = 2, Name = "John" },
        new Character { Id = 3, Name = "Ian" },
        new Character { Id = 4, Name = "Alex" },
        new Character { Id = 5, Name = "Joseph" }
    };
    [HttpGet("GetAll")]
    public ActionResult<List<Character>> Get()
    {
        return Ok(characters);
    }
    [HttpGet]
    public ActionResult<Character> GetSingleCharacter(int id)
    {
        return Ok(characters.FirstOrDefault(c=> c.Id == id));
    }
}

