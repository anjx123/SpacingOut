using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraResizer : MonoBehaviour
{
    public float aspectRatio = 16f / 9f; // set your desired aspect ratio here

    private Camera cam;

    //Effect: Upon awakening, sets the camera to the provided aspect ratio
    void Awake()
    {
        cam = GetComponent<Camera>();
        cam.aspect = aspectRatio;
    }
}