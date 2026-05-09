using UnityEngine;

public class UiButtons : MonoBehaviour
{
    public void ChangeScene(int scene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
