using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MenuMusic : MonoBehaviour {

    public AudioMixerSnapshot Level_1;
    public AudioClip stings;
    public AudioSource stingSource;

	// Use this for initialization
	void Start () {
        stingSource.clip = stings;
        stingSource.Play();
	
	}
	
	// Update is called once per frame
	void Update () {
	
        
	}
}
