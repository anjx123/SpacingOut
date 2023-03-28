using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class FadeController : MonoBehaviour
{

    public Animator sceneAnimator;

    private void Start() {
        sceneAnimator = GetComponent<Animator>();
    }
  
    //Sets the fade of this object to the input state
    public void setFade(bool state) {
        sceneAnimator.SetBool("InScene", state);
    }
}
