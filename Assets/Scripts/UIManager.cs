using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject pauseUI;
    public GameObject promptText;
    public GameObject dialoguePanel;
    public TMP_Text dialogueText;

    public void TogglePause()
    {
        pauseUI.SetActive(!pauseUI.activeSelf);
    }

    public void ShowPrompt()
    {
        promptText.SetActive(true);
    }

    public void HidePrompt()
    {
        promptText.SetActive(false);
    }

    public void ShowDialoguePanel()
    {
        dialoguePanel.SetActive(true);
    }

    public void SetDialogueText(string dialogueString)
    {
        dialogueText.text = dialogueString;
    }

    public void HideDialoguePanel()
    {
        dialoguePanel.SetActive(false);
    }
}
