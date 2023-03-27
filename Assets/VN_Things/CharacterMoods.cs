using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoods : MonoBehaviour
{
  public CharacterName Name;
  public Sprite Happy;
  public Sprite Beaming;
  public Sprite Serious;
  public Sprite Shocked;
  public Sprite Concentrated;
  public Sprite Nonchalant;
  public Sprite NonchalantSide;
  public Sprite NonchalantUp;
  public Sprite Silhouette;
  
  public Sprite GetMoodSprite(CharacterMood mood)
  {
    switch (mood)
    {
      case CharacterMood.Happy:
        return Happy;
      case CharacterMood.Beaming:
        return Beaming;
      case CharacterMood.Serious:
        return Serious;
      case CharacterMood.Shocked:
        return Shocked;
      case CharacterMood.Concentrated:
        return Concentrated;
      case CharacterMood.Nonchalant:
        return Nonchalant;
      case CharacterMood.NonchalantSide:
        return NonchalantSide;
      case CharacterMood.NonchalantUp:
        return NonchalantUp;
      case CharacterMood.Silhouette:
        return Silhouette;
      default:
        Debug.Log($"Didn't find Sprite for character: {Name}, mood: {mood}");
        return Nonchalant;
  }

}

}