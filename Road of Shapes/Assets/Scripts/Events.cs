using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Events : MonoBehaviour
{
    public float RotateSpeed = 10000f;
    public Text highscore;
    public void Start()
    {
        highscore.text = PlayerPrefs.GetInt("", 0).ToString();
       

    }
    private void Update()
    {
        if (PlayerManag.Score > PlayerPrefs.GetInt("", 0))
        {
            PlayerPrefs.SetInt("", (int)PlayerManag.Score);

            highscore.text = "" + PlayerManag.scoreint.ToString();
        }
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void MainMenu() 
    {
         SceneManager.LoadScene("MainMenuScene");
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotateSpeed * 10);
    }
    public void mute()
    {
        AudioListener.pause = !AudioListener.pause;

    }




}
