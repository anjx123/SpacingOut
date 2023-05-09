using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//This class handles Rolling Text behavior, Use this in place of TextMeshProUGUI components to set text
public class Dialogue : MonoBehaviour
{
    private const float DEFAULTROLLSPEED = 50f;

    public TextMeshProUGUI textComponent;
    private string currentLine;

    public float rollingSpeed;
    private int index;

    private bool lineIsFinished;

    public void SetLine(string line) 
    {
        textComponent.text = string.Empty;
        this.currentLine = line;
        StartDialogue();
    }


    // Start is called before the first frame update
    void Start()
    {
        if (rollingSpeed == 0)
        {
            rollingSpeed = DEFAULTROLLSPEED;
        }
        textComponent.text = string.Empty;

    }

    // Update is called once per frame
    void Update()
    {
        if (textComponent.text == currentLine)
        {
            lineIsFinished = true;
        } else 
        {
            lineIsFinished = false;
        }

        if(Input.GetMouseButtonUp(0) || Input.GetKeyDown(KeyCode.Space))
        {
            if(textComponent.text != currentLine)
            {
                StopAllCoroutines();
                textComponent.text = currentLine;
            }
        }
    }


    void StartDialogue()
    {
        StartCoroutine(TypeLine());
    }

    //Effects: Adds the rolling dialogue effect to the text
    IEnumerator TypeLine()
    {

        int currentIndex = 0;
        string displayedText = "";

        while (currentIndex < currentLine.Length)
        {
            displayedText += currentLine[currentIndex];
            currentIndex++;

            textComponent.text = displayedText;

            yield return new WaitForSecondsRealtime(1f / rollingSpeed);
        }
        
    }

    public bool FinishedLine()
    {
        return lineIsFinished;
    }

}
