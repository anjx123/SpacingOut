using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour, IDataPersistence
{
    public GameObject dialoguePanel;

    public GameObject yesbutton;

    public GameObject noButton;

    public SceneTransition sceneLoader;

    public TextMeshProUGUI dialogueText;

    public TextMeshProUGUI nameText;

    private Queue<string> sentences;

    private int totalSentenceCount;

    private bool inDialogue = false;

    private int scene = 3;


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
        dialogueText.text = sentence;
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

    public void LoadData(GameData data)
    {
        if (data.currentScene != SceneManager.GetActiveScene().buildIndex)
        {
            if (SceneManager.GetActiveScene().buildIndex == 0)
            {
                SceneManager.LoadScene(data.currentScene);
            }
        }
    }

    public void SaveData(ref GameData data)
    {
        data.currentScene = scene;
    }
}
