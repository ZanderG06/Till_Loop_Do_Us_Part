using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject player;

    public void LoadLevel(GameObject nextLevel, GameObject currentLevel, Transform spawn)
    {
        nextLevel.SetActive(true);
        currentLevel.SetActive(false);
        player.transform.position = spawn.position;
    }
}
