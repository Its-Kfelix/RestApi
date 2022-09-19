namespace Rpg3.Services;

public interface ICharacterServices
{
    List<Character>GetAllCharacters();
    Character GetCharacterById(int id);
    List<Character> AddCharacter(Character newCharacter);
}