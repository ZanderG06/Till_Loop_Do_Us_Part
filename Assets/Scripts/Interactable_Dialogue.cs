using UnityEngine;

public class Interactable_Dialogue : MonoBehaviour
{
    private DialogueManager dialogueManager;
    private QuestManager questManager;

    private string[] sentences;

    private void Start()
    {
        dialogueManager = ServiceHub.Instance.DialogueManager;
        questManager = ServiceHub.Instance.QuestManager;
    }

    public void Interact()
    {
        if (dialogueManager.inDialogue) dialogueManager.DisplayNextString();
        else
        {
            sentences = questManager.UpdateSentences(gameObject);
            dialogueManager.StartDialogue(sentences);
        }
        questManager.UpdateQuest(gameObject);
    }
}
