using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialoguePanel;

    public GameObject yesbutton;

    public GameObject noButton;

    public TextMeshProUGUI dialogueText;

    public TextMeshProUGUI nameText;

    private Queue<string> sentences;

    private int totalSentenceCount;

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

        Time.timeScale = 0;

        dialoguePanel.SetActive(true);
        yesbutton.SetActive(false);
        noButton.SetActive(false);

        nameText.text = dialogue.name;

        sentences.Clear();

        totalSentenceCount = dialogue.sentences.Length;

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
        dialogueText.text = sentence;
    }

    void EndDialogue()
    {
        clearPanel();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKey(KeyCode.Space))
        {
            if (sentences != null)
            {
                if (sentences.Count == 0 || sentences.Count == 5)
                {
                    DisplayNextSentence();
                }
            }
        }
    }
}
