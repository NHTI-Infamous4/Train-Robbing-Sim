﻿using UnityEngine;
using UnityEngine.Audio;

public class LevelMusic : MonoBehaviour
{
    public AudioMixerSnapshot Level;
    public AudioClip Normal;
    public AudioClip Intense;
    public AudioSource Source;

    // Use this for initialization
    private void Start()
    {
        Source.clip = Normal;
        Source.Play();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H)) // TO BE REMOVED LATER
        {
            Source.clip = Intense;
            Source.Play();
        }

        if (Input.GetKeyDown(KeyCode.J)) // TO BE REMOVED LATER
        {
            Source.clip = Normal;
            Source.Play();
        }
    }
}