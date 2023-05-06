using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Linq;

public class CharacterManager : MonoBehaviour
{

    private List<Character> characters;

    [SerializeField]
    private GameObject characterPrefab;

    [SerializeField]
    private CharacterMoods violetMoods;

    [SerializeField]
    private CharacterMoods lilacMoods;

    // Start is called before the first frame update
    void Start()
    {
        characters = new List<Character>();
    }

    public void ShowCharacter(CharacterName name, CharacterPosition position, CharacterMood mood)
    {
        var character = characters.FirstOrDefault(x => x.Name == name);

        if (character == null)
        {
            var characterObject = Instantiate(characterPrefab, gameObject.transform, false);

            character = characterObject.GetComponent<Character>();

            characters.Add(character);
        }
        else if (character.IsShowing)
        {
            Debug.LogWarning($"Failed to show character {name}. Character already showing");
            return;
        }

        character.Init(name, position, mood, GetMoodSetForCharacter(name), true);
    }

    public void ShowCharacter(string name, string position, string mood)
    {
        if (!Enum.TryParse(name, out CharacterName nameEnum))
        {
            Debug.LogWarning($"Failed to parse character name to enum: {name}");
            return;
        }

        if (!Enum.TryParse(position, out CharacterPosition positionEnum))
        {
            Debug.LogWarning($"Failed to parse character position to enum: {position}");
            return;
        }

        if (!Enum.TryParse(mood, out CharacterMood moodEnum))
        {
            Debug.LogWarning($"Failed to parse character mood to enum: {mood}");
            return;
        }

        ShowCharacter(nameEnum, positionEnum, moodEnum);

    }

    public void HideCharacter(string name)
    {
        if (!Enum.TryParse(name, out CharacterName nameEnum))
        {
            Debug.LogWarning($"Failed to parse character name to character enum: {name}");
            return;
        }

        HideCharacter(nameEnum);
    }

    public void HideCharacter(CharacterName name)
    {
        var character = characters.FirstOrDefault(x => x.Name == name);
        if (character?.IsShowing != true)
        {
            Debug.LogWarning($"Character {name} is not currently shown. Can't hide it.");
            return;
        }
        else
        {
            character.Hide();
        }
    }

    public void ChangeMood(string name, string mood)
    {

        if (!Enum.TryParse(name, out CharacterName nameEnum))
        {
            Debug.LogWarning($"Failed to parse character name to character enum: {name}");
            return;
        }
        
        if (!Enum.TryParse(mood, out CharacterMood moodEnum))
        {
            Debug.LogWarning($"Failed to parse character mood to enum: {mood}");
            return;
        }

        ChangeMood(nameEnum, moodEnum);
    }

    private void ChangeMood(CharacterName name, CharacterMood mood)
    {
        var character = characters.FirstOrDefault(x => x.Name == name);

        if (character?.IsShowing != true)
        {
            Debug.LogWarning($"Character {name} is not currently shown. Can't change the mood.");
            return;
        }
        else
        {
            character.ChangeMood(mood);
        }
    }

    public void ChangePosition(string name, string position)
    {
        if (!Enum.TryParse(name, out CharacterName nameEnum))
        {
            Debug.LogWarning($"Failed to parse character name to character enum: {name}");
            return;
        }
        
        if (!Enum.TryParse(position, out CharacterPosition positionEnum))
        {
            Debug.LogWarning($"Failed to parse character mood to enum: {position}");
            return;
        }

        ChangePosition(nameEnum, positionEnum);
    }

    private void ChangePosition(CharacterName name, CharacterPosition position)
    {
        var character = characters.FirstOrDefault(x => x.Name == name);

        if (character?.IsShowing != true)
        {
            Debug.LogWarning($"Character {name} is not currently shown. Can't change the position.");
            return;
        }
        else
        {
            character.ChangePosition(position);
        }
    }



    public void FadeInCharacter(CharacterName name, CharacterPosition position, CharacterMood mood)
    {
        var character = characters.FirstOrDefault(x => x.Name == name);

        if (character == null)
        {
            var characterObject = Instantiate(characterPrefab, gameObject.transform, false);

            character = characterObject.GetComponent<Character>();

            characters.Add(character);
        }
        else if (character.IsShowing)
        {
            Debug.LogWarning($"Failed to FadeIn character {name}. Character already showing");
            return;
        }

        character.Init(name, position, mood, GetMoodSetForCharacter(name), false);
    }

    public void FadeInCharacter(string name, string position, string mood)
    {
        if (!Enum.TryParse(name, out CharacterName nameEnum))
        {
            Debug.LogWarning($"Failed to parse character name to enum: {name}");
            return;
        }

        if (!Enum.TryParse(position, out CharacterPosition positionEnum))
        {
            Debug.LogWarning($"Failed to parse character position to enum: {position}");
            return;
        }

        if (!Enum.TryParse(mood, out CharacterMood moodEnum))
        {
            Debug.LogWarning($"Failed to parse character mood to enum: {mood}");
            return;
        }

        FadeInCharacter(nameEnum, positionEnum, moodEnum);

    }

    public void FadeOutCharacter(string name)
    {
        if (!Enum.TryParse(name, out CharacterName nameEnum))
        {
            Debug.LogWarning($"Failed to parse character name to character enum: {name}");
            return;
        }

        FadeOutCharacter(nameEnum);
    }

    public void FadeOutCharacter(CharacterName name)
    {
        var character = characters.FirstOrDefault(x => x.Name == name);
        if (character?.IsShowing != true)
        {
            Debug.LogWarning($"Character {name} is not currently shown. Can't FadeOut it.");
            return;
        }
        else
        {
            character.FadeOut();
        }
    }

    private CharacterMoods GetMoodSetForCharacter(CharacterName name)
    {
        switch (name)
        {
            case CharacterName.Violet:
                return violetMoods;
            case CharacterName.Lilac:
                return lilacMoods;
            default:
                Debug.LogError($"Could not find moodset for {name}");
            return null;
        }
    }

}
