using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractNPC : MonoBehaviour, IInteractable
{
    public DialogueTrigger dialogueTrigger;
    public GameObject dialoguePanel;

    public void Interact()

    {
        if (dialogueTrigger != null)
        {
            dialoguePanel.SetActive(true);
            dialogueTrigger.StartDialogue();
        }
        else
        {
            Debug.LogError("na");
        }
    }
    public string GetDescription()
    {
        return "E to interact";
    }
}
