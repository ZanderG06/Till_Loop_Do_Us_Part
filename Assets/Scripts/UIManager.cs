using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject pauseUI;

    public void TogglePause()
    {
        pauseUI.SetActive(!pauseUI.activeSelf);
    }
}
