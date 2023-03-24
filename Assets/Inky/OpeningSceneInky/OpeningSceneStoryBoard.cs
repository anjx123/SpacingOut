using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
using TMPro;
using UnityEngine.SceneManagement;

public class OpeningSceneStoryBoard : MonoBehaviour{

    [SerializeField]
	private TextAsset inkJSONAsset;
	public Story story;

    public TMP_Text dialogueBox;
    public TMP_Text nameBox;

    
    private const float SCENE_CHANGE_TIME = 3.0f;



    // Start is called before the first frame update
    void Start()
    {
        StartStory();
    }

    //Effects: Starts the story on awakening
    void Awake() {
    }

    //Modifies: this
    //Effects: Initializes story by setting the story to the inputted JSON file
    void StartStory() {
        story = new Story(inkJSONAsset.text);
        story.BindExternalFunction("setName", (string name) => setName(name));
        story.BindExternalFunction("setComponentFade", (string componentName, bool fade) => setComponentFade(componentName, fade));
        story.BindExternalFunction("sceneChange", (string sceneName) => sceneChange(sceneName));
        displayNextLine();
    } 


    // Update is called once per frame, waits for space or mouse press to continue dialogue
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            displayNextLine();
        } 
        if(Input.GetMouseButtonUp(0)) {
            displayNextLine();
        }
    }

    //Effects: Displays the next line in the inky file if it exists
    public void displayNextLine() {

        if (story.canContinue) {
           string text = story.Continue();
           text = text?.Trim();
           dialogueBox.text = text;
        } 
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
