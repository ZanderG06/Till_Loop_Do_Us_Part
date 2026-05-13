using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private int currentLoop = 1;

    public AudioClip alarmClock;
    private bool alarmClockOff = false;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.clip = alarmClock;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void UpdateQuest(GameObject npc)
    {
        if (npc.name == "AlarmClock")
        {
            audioSource.Stop();
            alarmClockOff = true;
        }
    }

    public string[] UpdateSentences(GameObject npc)
    {
        if(npc.name == "AlarmClock")
        {
            if (currentLoop == 1 && !alarmClockOff) return new string[] { "(You turn off your alarm clock)", "(The morning seems lovely, and it's even better knowing you have a date today)", "(Your phone vibrates, it's a text from her, she's outside right now!)" };
            else return new string[] { "(Your alarm is already turned off)", "(She's waiting for you! Hurry Up!)", "(Very convenient that you don't gotta get dressed)" };
        }
        return new string[] { "If you can read this, then I screwed up a line of code, Sorgy :c" };
    }
}
