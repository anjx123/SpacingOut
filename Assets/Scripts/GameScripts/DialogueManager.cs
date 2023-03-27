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

    void Start ()
    {
        sentences = new Queue<string>();
        clearPanel();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        dialoguePanel.SetActive(true);

        nameText.text = dialogue.name;

        sentences.Clear();

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
        Debug.Log("End of Conversation");
        clearPanel();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse0))
        {
            EndDialogue();
        }
    }
}
