using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public static SoundControl soundControl;
    private AudioSource audioSource;
    private AudioClip[] buttonSounds;
    private int randomButtonSound;
    private bool isEasterEgg;

    private void Start()
    {
        soundControl = this;
        audioSource = GetComponent<AudioSource>();
        buttonSounds = Resources.LoadAll<AudioClip>("Sounds/Button");
    }

    public void PlayButtonSound()
    {
        if (!audioSource.isPlaying)
        {
            if (Random.Range(0, 101) == 100) isEasterEgg = true;
            else isEasterEgg = false;
            randomButtonSound = Random.Range(0, 9);
            // Unblock for 100% EasterEgg
            // isEasterEgg = true;
            // randomButtonSound = 9;
            print("EasterEgg?: " + isEasterEgg + " | Sound: " + randomButtonSound);
            switch (isEasterEgg)
            {
                case true:
                    audioSource.PlayOneShot(buttonSounds[9]);
                    break;
                default:
                    audioSource.PlayOneShot(buttonSounds[randomButtonSound]);
                    break;
            }
        }
    }
}
