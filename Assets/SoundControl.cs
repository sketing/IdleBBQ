using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public static SoundControl soundControl;
    private AudioSource audioSource;
    private AudioClip[] buttonSounds;
    private int randomButtonSound;

    private void Start()
    {
        soundControl = this;
        audioSource = GetComponent<AudioSource>();
        buttonSounds = Resources.LoadAll<AudioClip>("Sounds/Button");
    }

    public void PlayButtonSound()
    {
        randomButtonSound = Random.Range(0, 10);
        print(randomButtonSound);
        audioSource.PlayOneShot(buttonSounds[randomButtonSound]);
    }
}
