using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraResizer : MonoBehaviour
{
    public float aspectRatio = 16f / 9f; // set your desired aspect ratio here

    private Camera cam;

    void Awake()
    {
        cam = GetComponent<Camera>();
        cam.aspect = aspectRatio;
    }
}