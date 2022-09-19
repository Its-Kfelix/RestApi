namespace Rpg3.Services;

public class CharacterServices:ICharacterServices
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
    public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
    {
        return new ServiceResponse<List<Character>>() { Data = characters };
    }

    public async Task<ServiceResponse<Character>> GetCharacterById(int id)
    {
        var serviceResponse = new ServiceResponse<Character>();
        var character = characters.FirstOrDefault(c => c.Id == id);
        serviceResponse.Data = character;
        return serviceResponse;
    }

    public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
    {
        var serviceResponse = new ServiceResponse<List<Character>>();
        characters.Add(newCharacter);
        serviceResponse.Data = characters;
        return serviceResponse;
    }
}