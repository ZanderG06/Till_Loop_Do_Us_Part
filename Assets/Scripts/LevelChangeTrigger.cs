using UnityEngine;

public class LevelChangeTrigger : MonoBehaviour
{
    private LevelManager levelManager;
    private QuestManager questManager;

    public GameObject nextLevel;
    public GameObject currentLevel;
    public Transform spawn;

    private void Start()
    {
        levelManager = ServiceHub.Instance.LevelManager;
        questManager = ServiceHub.Instance.QuestManager;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            levelManager.LoadLevel(nextLevel, currentLevel, spawn);
            questManager.StopAudioSource();
        }
    }
}
