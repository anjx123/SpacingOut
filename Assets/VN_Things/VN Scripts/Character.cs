using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Character : MonoBehaviour
{

    public CharacterPosition Position { get; private set; }
    public CharacterName Name { get; private set; }
    public CharacterMood Mood { get; private set; }

    public bool IsShowing { get; private set; }

    private CharacterMoods _moods;

    private float offScreenX;
    private float onScreenX;

    private readonly float animationSpeed = 0.5f;

    public void Init(CharacterName name, CharacterPosition position, CharacterMood mood, CharacterMoods moods, bool movement)
    {
        Name = name;
        Position = position;
        Mood = mood;

        _moods = moods;

        if (movement) {
            Show();
        } else {
            FadeIn();
        }
        
    }

    public void Show()
    {

        SetAnimationValues();

        // Position outside of the screen
        transform.position = new Vector3(offScreenX, transform.position.y, transform.localPosition.z);

        // Set correct mood sprite
        UpdateSprite();

        LeanTween.moveX(gameObject, onScreenX, animationSpeed).setEase(LeanTweenType.linear).setOnComplete(() =>
        {
            IsShowing = true;
        });
    }

    public void Hide()
    {

        LeanTween.moveX(gameObject, offScreenX, animationSpeed).setEase(LeanTweenType.linear).setOnComplete(() =>
        {
            IsShowing = false;
        });
    }

    private void SetAnimationValues()
    {
        switch (Position)
        {
            case CharacterPosition.Left:
            onScreenX = Screen.width * 0.25f;
            offScreenX = -Screen.width * 0.25f;
            break;
            
            case CharacterPosition.Center:
            onScreenX = Screen.width * 0.5f;
            offScreenX = -Screen.width * 0.25f;
            break;

            case CharacterPosition.Right:
            onScreenX = Screen.width * 0.75f;
            offScreenX = Screen.width * 1.25f;
            break;
        }
    }

    public void ChangeMood(CharacterMood mood)
    {
        Mood = mood;
        UpdateSprite();
    }

    private void UpdateSprite()
    {
        var sprite = _moods.GetMoodSprite(Mood);
        var image = GetComponent<Image>();

        image.sprite = sprite;
        image.preserveAspect = true;
    }

    public void FadeIn()
    {

        SetAnimationValues();

        // Position outside of the screen
        transform.position = new Vector3(onScreenX, transform.position.y, transform.localPosition.z);

        // Set correct mood sprite
        UpdateSprite();

        LeanTween.alpha(gameObject, 1f, 1f).setEase(LeanTweenType.linear).setOnComplete(() =>
        {
            IsShowing = true;
        });
    }

    public void FadeOut()
    {
        LeanTween.alpha(gameObject, 0f, 1f).setEase(LeanTweenType.linear).setOnComplete(() =>
        {
            IsShowing = false;
        });
    }

}
