namespace Rpg3.Services;

public interface ICharacterServices
{
    Task<ServiceResponse<List<Character>>>GetAllCharacters();
    Task<ServiceResponse<Character>> GetCharacterById(int id);
    Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
}