
using UnityEngine;
using System.Collections;

public class BubbleSound : MonoBehaviour
{
    public float Timer;
    public Transform Player;
    public Transform Trigger;
    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
 //   public bool alreadyPlayed = false;
    void Start()
    {
        audio = GetComponent<AudioSource>();
        Trigger = this.transform;
        Timer = SoundToPlay.length;
    }
    void OnTriggerStay()
    {
        Timer -= Time.deltaTime;
        
        if (Timer < 0) 
        {
            audio.PlayOneShot(SoundToPlay, Volume);
            Timer = SoundToPlay.length;
        }
       
            
    }
}
