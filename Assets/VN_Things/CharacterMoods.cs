using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoods : MonoBehaviour
{
  public CharacterName Name;
  public Sprite Happy;
  public Sprite Serious;
  public Sprite Shocked;
  
  public Sprite GetMoodSprite(CharacterMood mood)
  {
    switch (mood)
    {
      case CharacterMood.Happy:
        return Happy;
      case CharacterMood.Serious:
        return Serious;
      case CharacterMood.Shocked:
        return Shocked;
      default:
        Debug.Log($"Didn't find Sprite for character: {Name}, mood: {mood}");
        return Happy;
  }

}

}