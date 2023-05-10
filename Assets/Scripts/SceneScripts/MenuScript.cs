using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Sets
public class MenuScript : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private float timestamp;
    [SerializeField]
    private GameObject fader;

    private FadeController fadeScreen;
    private Transform fadeTransform;
    private Image fadeImage;

    private const float SCENE_CHANGE_TIME = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.fadeTransform = fader.GetComponent<Transform>();
        this.fadeScreen = fader.GetComponent<FadeController>();
        this.fadeImage = fader.GetComponent<Image>();
        audioSource.time = timestamp;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeImage.color.a == 0) {
            fadeTransform.SetAsFirstSibling();
        } else {
            fadeTransform.SetAsLastSibling();
        }
    }

    public void StartGame() {
        sceneChange("Scene 1");
    }

    public void OpenSetting() {
        
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void OpenCollection() {
        
    }

    //Effects: Swaps this scene with the scene of the given name;
    public void sceneChange(string sceneName) {
        fadeScreen.setFade(true);
        StartCoroutine(fadeMusicOut());
        StartCoroutine(waitForSceneToChange(sceneName));
    }

    //Effects: Waits for a set amount of time before changing scenes
    IEnumerator waitForSceneToChange(string sceneName) {
        yield return new WaitForSeconds(SCENE_CHANGE_TIME);
        SceneManager.LoadScene(sceneName);
    }

    private IEnumerator fadeMusicOut()
    {
        float fadeTimer = 0f;
        float fadeOutTime = 1f;
        while (fadeTimer < fadeOutTime) 
        {
            audioSource.volume = Mathf.Lerp(1, 0, fadeTimer / fadeOutTime);
            fadeTimer += Time.deltaTime;
            yield return new WaitForSeconds(fadeOutTime / 1000f);
        }
        audioSource.Stop();
        
    }
}
