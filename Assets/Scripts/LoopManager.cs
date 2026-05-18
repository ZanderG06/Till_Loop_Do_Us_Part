using UnityEngine;

public class LoopManager : MonoBehaviour
{
    private QuestManager questManager;

    private void Start()
    {
        questManager = ServiceHub.Instance.QuestManager;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        questManager.currentLoop++;
        questManager.StartAudioSource();
    }
}
