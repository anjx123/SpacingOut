using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButtonScript : MonoBehaviour
{
  private InkManager inkManager;

  void Start()
  {
    inkManager = FindObjectOfType<InkManager>();

    if (inkManager == null)
    {
      Debug.LogError("Ink Manager was not found!");
    }
  }

  public void OnClick()
  {
    inkManager?.DisplayNextLine();
  }
}
