using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    
    private static int POOL_SIZE = 3; // Number of audio tracks instantiated when script is run

    private AudioSource selectedSource;
    private AudioSource[] audioTracks; // Array of all the available tracks that can play audio.
    private Dictionary<string, AudioSource> activeTracks; // Maps active tracks to the sound name they are playing;


    public AudioClip[] audioClips; // Array of all audio clips in the project you want to preload
    private Dictionary<string, AudioClip> audioClipDict; // Dictionary mapping audio clip names to audio clip objects

    public float fadeInTime = 0.1f; //Might want to add to the inky function a fade time, but this constant is here if you need it. 
    public float fadeOutTime = 1.0f;

    private bool isFadingIn = false;
    private bool isFadingOut = false; 
    private float fadeTimer = 0.0f; //A timer that keeps track of how long the fade has been going on.
    private float initialVolume = 0.1f; 
    private float finalVolume = 0.4f;

    // Start is called before the first frame update
    void Start()
    {       
        // Load all audio clips and store them in the audioClipDict dictionary
        audioClipDict = new Dictionary<string, AudioClip>();
        foreach (AudioClip clip in audioClips)
        {
            audioClipDict.Add(clip.name, clip);
        }

        audioTracks = new AudioSource[POOL_SIZE];
        for (int i = 0; i < audioTracks.Length; i++)
        {
            audioTracks[i] = gameObject.AddComponent<AudioSource>();
            audioTracks[i].playOnAwake = false;
        }

        activeTracks = new Dictionary<string, AudioSource>();
    }

    // Update is called once per frame and watches to see whether the audio is fading in or out
    void Update()
    {
        if (isFadingIn)
        {
            fadeTimer += Time.deltaTime;
            selectedSource.volume = Mathf.Lerp(initialVolume, finalVolume, fadeTimer / fadeInTime);
            if (fadeTimer >= fadeInTime)
            {
                isFadingIn = false;
            }
        }
        else if (isFadingOut)
        {
            
            selectedSource.loop = false;
            fadeTimer += Time.deltaTime;
            selectedSource.volume = Mathf.Lerp(finalVolume, initialVolume, fadeTimer / fadeOutTime);
            if (fadeTimer >= fadeOutTime)
            {
                isFadingOut = false;
                selectedSource.Stop();
            }
        }
    }

    //Requires: Song provided needs to be loaded in
    // Finds the song that has been loaded in and plays it in a empty audioTrack
    public void Play(string soundName)
    {
    if (audioClipDict.ContainsKey(soundName))
    {
        for (int i = 0; i < audioTracks.Length; i++)
        {
            if (!audioTracks[i].isPlaying)
            {   

                audioTracks[i].clip = audioClipDict[soundName];
                activeTracks[soundName] = audioTracks[i];

                audioTracks[i].volume = 0.1f;
                initialVolume = audioTracks[i].volume;
                isFadingIn = true;
                selectedSource  = audioTracks[i];
                selectedSource.Play();
                break;
            }
        }
    } else
    {
         Debug.LogWarning("Audio clip not found: " + soundName);
    }
    }

    //Effect: Stops a given song from playing 
    public void Stop(string soundName)
    {   
        if (activeTracks.ContainsKey(soundName)) {
        selectedSource = activeTracks[soundName];
        fadeTimer = 0.0f;
        finalVolume = selectedSource.volume;
        isFadingOut = true;
        activeTracks.Remove(soundName);
        } else {
        Debug.LogWarning(soundName + " is not actively being played");
        }
        
    }

    //Effects: Sets the song to loop, if you only want specific songs to loop, I recommend you create a new class to store that info.
    public void Loop(string soundName, bool isLoop)
    {
        if (activeTracks.ContainsKey(soundName)) {
        selectedSource = activeTracks[soundName];
        selectedSource.loop = isLoop;
        } else {
        Debug.LogWarning(soundName + " is not actively being played");
        }
    }
}
