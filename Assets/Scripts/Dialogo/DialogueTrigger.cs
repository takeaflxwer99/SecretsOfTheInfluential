using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    /// <summary>
    /// This method is plugged in to whatever method is 
    /// responsible for triggering the Dialogue in the scene
    /// </summary>
    public void StartDialogue()
    {
        FindObjectOfType<DialogueManager>().StartUpDialogue(dialogue);
    }
}
