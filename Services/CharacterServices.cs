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
    public List<Character> GetAllCharacters()
    {
        return characters;
    }

    public Character GetCharacterById(int id)
    {
        return characters.FirstOrDefault(c=>c.Id == id);
    }

    public List<Character> AddCharacter(Character newCharacter)
    {
        characters.Add(newCharacter);
        return characters;
    }
}