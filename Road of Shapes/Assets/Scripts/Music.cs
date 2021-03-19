using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public  AudioClip[] music;
    private static AudioSource audioSource;
    private float musicVolume;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.loop = false;
    }

    private AudioClip GetRandomClip() {

        return music[Random.Range(0, music.Length)];
    }
    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying) { 
            audioSource.clip =GetRandomClip();
            audioSource.Play();
        
        }
        
    }
    
    
}
