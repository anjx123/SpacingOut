using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoaderSetup : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        Camera mainCamera = Camera.main;
        if (mainCamera != null)
        {
            Canvas canvas = GetComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceCamera;
            canvas.worldCamera = mainCamera;
        }
        else
        {
            Debug.LogError("Main camera not found in scene");
        }
        
    }

}
