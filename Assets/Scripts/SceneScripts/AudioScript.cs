using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip[] audioClips; // Array of all audio clips in the project you want to preload

    private Dictionary<string, AudioClip> audioClipDict; // Dictionary mapping audio clip names to audio clip objects

    public float fadeInTime = 0.0f; //Might want to add to the inky function a fade time, but this constant is here if you need it. 
    public float fadeOutTime = 1.0f;

    private bool isFadingIn = false;
    private bool isFadingOut = false; 
    private float fadeTimer = 0.0f; //A timer that keeps track of how long the fade has been going on.
    private float initialVolume = 0.0f; //The volume level of the audio before the fade started.

    // Start is called before the first frame update
    void Start()
    {
        
        // Load all audio clips and store them in the audioClipDict dictionary
        // This dictionary only loads AudioClips, if you want to load extra information like a specific volume to play the song at
        // create a new class and swap in that class for Audio Clip.
        audioClipDict = new Dictionary<string, AudioClip>();
        

        foreach (AudioClip clip in audioClips)
        {
            audioClipDict.Add(clip.name, clip);
        }
    }

    // Update is called once per frame and watches to see whether the audio is fading in or out
    void Update()
    {
        if (isFadingIn)
        {
            fadeTimer += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(initialVolume, 1.0f, fadeTimer / fadeInTime);
            if (fadeTimer >= fadeInTime)
            {
                isFadingIn = false;
            }
        }
        else if (isFadingOut)
        {
            fadeTimer += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(1.0f, initialVolume, fadeTimer / fadeOutTime);
            if (fadeTimer >= fadeOutTime)
            {
                isFadingOut = false;
                audioSource.Stop();
            }
        }
    }

    //Requires: Song provided needs to be loaded in, please run the stop command first this will play clips concurrently. 
    // Finds the song that has been loaded in and plays it
    public void Play(string songName)
    {
    
        if (audioClipDict.ContainsKey(songName))
        {
            audioSource.clip = audioClipDict[songName];
        }
        else
        {
            Debug.LogWarning("Audio clip not found: " + songName);
        }
        audioSource.volume = 0.0f;
        initialVolume = audioSource.volume;
        isFadingIn = true;
        audioSource.Play();
    }

    //Effect: Stops a given song from playing 
    public void Stop(string songName)
    {
        isFadingOut = true;
        fadeTimer = 0.0f;
        initialVolume = audioSource.volume;
    }

    //effects: Sets the song to loop, if you only want specific songs to loop, I recommend you create a new class to store that info.
    public void Loop(bool isLoop)
    {
        audioSource.loop = isLoop;
    }
}
