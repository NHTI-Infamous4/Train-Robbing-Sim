using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class LevelMusic : MonoBehaviour {

    public AudioMixerSnapshot Level;
    public AudioClip Normal;
    public AudioClip Intense;
    public AudioSource Source;


    // Use this for initialization
    void Start() {

        Source.clip = Normal;
        Source.Play();
    }


	
	// Update is called once per frame
	void Update () {
	
        if (Input.GetKeyDown(KeyCode.H))
        {
            Source.clip = Intense;
            Source.Play();
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            Source.clip = Normal;
            Source.Play();
        }
	}
}
