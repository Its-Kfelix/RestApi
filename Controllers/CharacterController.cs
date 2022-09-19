
using Microsoft.AspNetCore.Mvc;
using Rpg3.Services;

namespace Rpg3.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController: ControllerBase
{
    //added a dependency injection to inject the characterservices
    //interface to the charactercontroller
    private readonly ICharacterServices _characterServices;

    public CharacterController(ICharacterServices characterServices)
    {
        _characterServices = characterServices;
    }
  
    [HttpGet("GetAll")]
    public async Task<ActionResult<List<Character>>> Get()
    {
        return Ok(await _characterServices.GetAllCharacters());
    }
    [HttpGet]
    public async Task<ActionResult<Character>> GetSingleCharacter(int id)
    {
        return Ok(await _characterServices.GetCharacterById(id));
    }

    [HttpPost]
    public async Task<ActionResult<List<Character>>> AddCharacters(Character newCharacter)
    {
        return Ok(await _characterServices.AddCharacter(newCharacter));
    }
}

