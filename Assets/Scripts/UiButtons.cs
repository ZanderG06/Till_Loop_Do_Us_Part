using UnityEngine;

public class UiButtons : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject credits;

    public void ChangeScene(int scene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Credits()
    {
        credits.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void Menu()
    {
        credits.SetActive(false);
        mainMenu.SetActive(true);
    }
}
