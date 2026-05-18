using Unity.VisualScripting;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public int currentLoop = 1;

    public AudioClip alarmClock;
    private bool alarmClockOff = false;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();

        StartAudioSource();
    }

    public void UpdateQuest(GameObject npc)
    {
        if (npc.name == "AlarmClock") StopAudioSource();
    }

    public void StartAudioSource()
    {
        audioSource.clip = alarmClock;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void StopAudioSource()
    {
        audioSource.Stop();
        alarmClockOff = true;
    }

    public string[] UpdateSentences(GameObject npc)
    {
        if(npc.name == "AlarmClock")
        {
            if (currentLoop == 1 && !alarmClockOff) return new string[] { "(You turn off your alarm clock)", "(The morning seems lovely, and it's even better knowing you have a date today)", "(Your phone vibrates, it's a text from her, she's outside right now!)" };
            if (currentLoop == 2) return new string[] { "(You turn off your- Wait a minute)", "(Weren't you just here?)", "(Your phone vibrates, it's a text from your date, didn't you already get this text though?)" };
            if (currentLoop >= 3) return new string[] { "(Yeah something's not right)", "(There's gotta be some kind of way to get out of this right????)", "(It's a text..... from her)" };
            else return new string[] { "(Your alarm is already turned off)", "(She's waiting for you! Hurry Up!)", "(Very convenient that you don't gotta get dressed)" };
        }
        else if(npc.name == "LoveInterest")
        {
            if (currentLoop == 1) return new string[] { "(It's her, your date. Just looking at her wants you to get.......)", "(TOGETHER (Wait..... Fire Writing??????))", "Hey :3 come on we're gonna be late for the Festival!" };
            if (currentLoop == 2) return new string[] { "(It's her, but weren;t you just here?)", "(Something's going on, but maybe it was just a dream?)", "Hey :3 come on we're gonna be late for the Festival!" };
            else return new string[] { "(This isn't right.... you were just here)", "(There's gotta be something you can do... right?????)", "(Thanks for enjoying this short demo, sorry there couldn't be more, our team did not have a lot of free time on our hands)" };
        }
        return new string[] { "If you can read this, then I screwed up a line of code, Sorgy :c" };
    }
}
