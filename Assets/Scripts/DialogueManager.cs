using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    private UIManager uiManager;
    private PlayerController playerController;

    private Queue<string> dialogueQueue;

    public bool inDialogue = false;

    private void Start()
    {
        uiManager = ServiceHub.Instance.UIManager;

        dialogueQueue = new Queue<string>();
    }

    public void StartDialogue(string[] sentences)
    {
        uiManager.ShowDialoguePanel();
        inDialogue = true;
        playerController = ServiceHub.Instance.PlayerController;

        foreach (string currentString in sentences) dialogueQueue.Enqueue(currentString);

        DisplayNextString();
    }

    public void DisplayNextString()
    {
        if (dialogueQueue.Count == 0)
        {
            EndDialogue();
            return;
        }
        else uiManager.SetDialogueText(dialogueQueue.Dequeue());
    }
    
    public void EndDialogue()
    {
        dialogueQueue.Clear();

        uiManager.HideDialoguePanel();

        inDialogue = false;
        playerController.moveEnabled = true;
    }
}
