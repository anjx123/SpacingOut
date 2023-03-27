using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialoguePanel;

    public TextMeshProUGUI dialogueText;

    public TextMeshProUGUI nameText;

    private Queue<string> sentences;

    private int totalSentenceCount;

    void Start ()
    {
        sentences = new Queue<string>();
        clearPanel();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        Time.timeScale = 0;

        dialoguePanel.SetActive(true);

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

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    void EndDialogue()
    {
        clearPanel();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            EndDialogue();
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            DisplayNextSentence();
        }
    }
}
