using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Ink.Runtime;
using UnityEngine.SceneManagement;

public class InkManager : MonoBehaviour
{

    private CharacterManager characterManager;

    [SerializeField]
    private TextAsset inkJsonAsset;
    private Story story;

    [SerializeField]
    private TextMeshProUGUI textComponent;
    public TMP_Text nameBox;

    public SceneTransition sceneLoader;

    private const float SCENE_CHANGE_TIME = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        characterManager = FindObjectOfType<CharacterManager>();
        StartStory();
    }

    private void StartStory() 
    {
        story = new Story(inkJsonAsset.text);

        story.BindExternalFunction("setName", (string name) => setName(name));

        story.BindExternalFunction("setComponentFade", (string componentName, bool fade) => setComponentFade(componentName, fade));

        story.BindExternalFunction("sceneChange", (string sceneName) => sceneChange(sceneName));

        story.BindExternalFunction("ShowCharacter", (string name, string position, string mood) 
            => characterManager.ShowCharacter(name, position, mood));

        story.BindExternalFunction("HideCharacter", (string name) 
            => characterManager.HideCharacter(name));

        story.BindExternalFunction("FadeInCharacter", (string name, string position, string mood) 
            => characterManager.FadeInCharacter(name, position, mood));

        story.BindExternalFunction("FadeOutCharacter", (string name) 
            => characterManager.FadeOutCharacter(name));

        story.BindExternalFunction("ChangeMood", (string name, string mood) 
            => characterManager.ChangeMood(name, mood));

        story.BindExternalFunction("sceneLoader", () => sceneLoader.LoadNextScene());

        DisplayNextLine();

    }

    // Update is called once per frame, waits for space or mouse press to continue dialogue
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            DisplayNextLine();
        } 
        if(Input.GetMouseButtonUp(0)) {
            DisplayNextLine();
        }
    }

    public void DisplayNextLine()
    {
        if (!story.canContinue) return;

        string text = story.Continue(); // gets next line
        text = text?.Trim(); // removes white space from text
        textComponent.text = text; // displays new text
    }

    //Effects: Swaps this scene with the scene of the given name;
    public void sceneChange(string sceneName) {
        StartCoroutine(waitForSceneToChange(sceneName));
    	

    }

    //Effects: Waits for a set amount of time before changing scenes
    IEnumerator waitForSceneToChange(string sceneName) {
        yield return new WaitForSeconds(SCENE_CHANGE_TIME);
        SceneManager.LoadScene(sceneName);
    }

    //Modifies: this
    //Effects: Changes the name to this from inky
    public void setName(string name) {
        string speakerName = name;
        nameBox.text = speakerName;
    }

    //Effects: Changes the given component to fade in or out
    public void setComponentFade(string componentName, bool fade) {
        GameObject uiObject = GameObject.Find(componentName);
       
        uiObject.GetComponent<FadeController>().setFade(fade);
 
    }

}
