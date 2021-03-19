using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource levelMusic;
    public AudioSource deathSound;
    public AudioSource gemCollect;

    
    public bool levelSongTF = true;
    public bool deathSoundTF = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LevelMusic() {
        levelSongTF = true;
        deathSoundTF = false;
        levelMusic.Play();
    }
    public void DeathSound() {
        if (levelMusic.isPlaying) {
            levelSongTF = false;
            levelMusic.Stop();
        }
        if (!deathSound.isPlaying && deathSoundTF == false) {
            deathSound.Play();
            deathSoundTF = true;
        }


    }
    public void GemCollecting() {

        gemCollect.Play();
    }
}
