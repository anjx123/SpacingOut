using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : CollidableObject
{
    private bool z_Interacted = false;

    public DialogueTrigger dialogueTrigger;

    protected override void OnCollided(GameObject collidedObject)
    {
        if (collidedObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                OnInteract();
            }
        }
    }

    protected virtual void OnInteract()
    {
        if (!z_Interacted)
        {
            dialogueTrigger.TriggerDialogue();
        }
    }
}
