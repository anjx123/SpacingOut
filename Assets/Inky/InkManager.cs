using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;

public class InkManager : MonoBehaviour
{

[SerializeField]
private TextAsset inkJsonAsset;
private Story story;

[SerializeField]
private TextMeshProUGUI textComponent;


    // Start is called before the first frame update
    void Start()
    {
        StartStory();
    }

    private void StartStory() 
    {
        story = new Story(inkJsonAsset.text);
        DisplayNextLine();
    }

    public void DisplayNextLine()
    {
        if (!story.canContinue) return;

        string text = story.Continue(); // gets next line
        text = text?.Trim(); // removes white space from text
        textComponent.text = text; // displays new text
    }
}
