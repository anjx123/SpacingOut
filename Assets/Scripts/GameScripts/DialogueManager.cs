using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialoguePanel;

    public GameObject yesbutton;

    public GameObject noButton;

    public SceneTransition sceneLoader;

    public Dialogue dialogueText;

    public TextMeshProUGUI nameText;

    private Queue<string> sentences;

    private int totalSentenceCount;

    private bool inDialogue = false;

    void Start ()
    {
        sentences = new Queue<string>();
        clearPanel();

    }

    public void StartDialogue (RPGDialogue dialogue)
    {
        if (dialoguePanel.activeInHierarchy)
        {
            return;
        }

        Time.timeScale = 0; //Time is frozen yet I can still turn and iteract BUG

        dialoguePanel.SetActive(true);
        yesbutton.SetActive(false);
        noButton.SetActive(false);

        nameText.text = dialogue.name;

        sentences.Clear();

        totalSentenceCount = dialogue.sentences.Length;

        inDialogue = true;

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void clearPanel()
    {
        dialoguePanel.SetActive(false);
        nameText.text = "";
        sentences.Clear();
        Time.timeScale = 1;
        inDialogue = false;
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        if (sentences.Count < 6)
        {
            yesbutton.SetActive(true);
            noButton.SetActive(true);
        }

        if (sentences.Count == 1)
        {
            yesbutton.SetActive(false);
            noButton.SetActive(false);
        }

        string sentence = sentences.Dequeue();

        dialogueText.SetLine(sentence);
    }

    void EndDialogue()
    {
        if (1 == 1)
        {
            sceneLoader.LoadNextScene();
        }
        clearPanel();
    }

    void Update()
    {
        if (dialogueText.FinishedLine())
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKey(KeyCode.Space))
            {
                if (inDialogue)
                {
                    if (sentences.Count == 0 || sentences.Count == 5)
                    {
                        DisplayNextSentence();
                    }
                }
            }
        }
    }
}
