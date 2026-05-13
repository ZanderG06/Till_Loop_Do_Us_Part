using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public AudioClip alarmClock;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.clip = alarmClock;
        audioSource.loop = true;
        audioSource.Play();
    }
}
