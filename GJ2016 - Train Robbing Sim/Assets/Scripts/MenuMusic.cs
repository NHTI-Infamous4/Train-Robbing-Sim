using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuMusic : MonoBehaviour
{
    public AudioMixerSnapshot Level_1;
    public AudioClip stings;
    public AudioSource stingSource;
    public Button Go;

    // Use this for initialization
    private void Start()
    {
        stingSource.clip = stings;
        stingSource.Play();
    }

    // Update is called once per frame
    private void Update()
    {

        
        
    }
}