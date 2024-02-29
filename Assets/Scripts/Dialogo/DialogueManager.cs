using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public Dialogue dialogue;
    public Text npcNameText;
    public Text dialogueText;
    Logger logger;
    public bool canLogDebugMessages = true;
    //Keep track of all sentences in our dialogue
    public Queue<string> sentencesInDialogue;

    private void Start()
    {
        logger = FindObjectOfType<Logger>();
        sentencesInDialogue = new Queue<string>();
    }

    public void StartUpDialogue(Dialogue dialogueToLoad)
    {
        //clear any previous sentences from the queue of sentences
        sentencesInDialogue.Clear();

        //add the incoming sentences onto the queue in order
        foreach (var sentence in dialogueToLoad.dialogueSentences)
        {
            sentencesInDialogue.Enqueue(sentence);
        }

        dialogue = dialogueToLoad;
        //now that we have sentences in the queue, start up the dialogue
        //and display the next sentence
        DisplayDialogueSentences();
    }

    /// <summary>
    /// This method is plugged into whatever event is in charge of continuing the dialogue
    /// </summary>
    public void DisplayDialogueSentences()
    {
        // Quick check if there are any sentences to display
        if (sentencesInDialogue.Count == 0)
        {
            // End the dialogue
            EndDialogue();
        }
        else
        {
            // Load a sentence from the queue
            string currentSentence = sentencesInDialogue.Dequeue();

            // Update UI elements with current dialogue information
            npcNameText.text = dialogue.npcName;
            dialogueText.text = currentSentence;

            // Log the sentence
            logger.LogDebugMessages(currentSentence, this, canLogDebugMessages);
        }
    }

    private void EndDialogue()
    {
        logger.LogDebugMessages("No more Messages", this, canLogDebugMessages);
    }
}
