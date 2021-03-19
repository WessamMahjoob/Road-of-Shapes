using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManag : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    public static bool Gameplay;
    public GameObject gamePlayPanel;
    public static bool isGameStarted;
    public static float Score;
    public static float ScorePerSecond;
    public Text ScoreText ;
    public Text ScoreTextTotal ;
    public Text HighScore;
    public static int Gems =0;
    public Text GemsText ;
    public static Material CircleBlue,SquareGreen,TriangleRed;
    public static GameObject c,s,t ;
    public Button PauseButton;
    public GameObject PauseUI;
    public Button PlayButton;
    public static int scoreint;
    public static bool GameIsPaused=false;
    private int gemcounter;
    public ParticleSystem DeathCircle,DeathCube,DeathTriangle;
    
    bool checker=false;
    public static string color;
    int timer = 0;
    
    void Start()
    {
        
        ScorePerSecond = 20f;
        c = GameObject.FindGameObjectWithTag("Circle");
        s = GameObject.FindGameObjectWithTag("Square");
        t = GameObject.FindGameObjectWithTag("Triangle");
        CircleBlue = c.GetComponent<Renderer>().material;
        SquareGreen= s.GetComponent<Renderer>().material;
        TriangleRed = t.GetComponent<Renderer>().material;
        c.GetComponent<MeshRenderer>().enabled = true;
        s.GetComponent<MeshRenderer>().enabled = false;
        t.GetComponent<MeshRenderer>().enabled = false;
        Time.timeScale = 1;
        gameOver = false;
        gamePlayPanel.SetActive(true);
        gameOverPanel.SetActive(false);
        PlayerController.speed = 5f;
        
        isGameStarted = false;
        Score = 0f;
        HighScore.text = PlayerPrefs.GetInt("", 0).ToString();
        gemcounter = PlayerPrefs.GetInt("gems", 0);
        Gems = gemcounter;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Score += ScorePerSecond * Time.deltaTime;
        if (gameOver)
        {
            FindObjectOfType<Sounds>().DeathSound();
            ScorePerSecond = 0;
                timer++;
                
                PlayerController.speed = 0;
                check();
                scoreint = (int)Score;

            if (timer >= 125)
            {
               
                gamePlayPanel.SetActive(false);
                 gameOverPanel.SetActive(true);
                Time.timeScale = 0;
                ScoreTextTotal.text = "Final Score : " + (int)Score;
                if (Score > PlayerPrefs.GetInt("", 0)) {
                    PlayerPrefs.SetInt("", (int)Score);

                    HighScore.text = "" + scoreint.ToString();
                }
                PlayerPrefs.SetInt("gems", Gems);
            }
        }
        ScoreText.text = ""+ (int)Score; 
        GemsText.text = "Gems =  " + Gems;
       




    }
    public void ReplayGame()
    {
        SceneManager.LoadScene("GameScene");
        FindObjectOfType<Sounds>().LevelMusic();

    }
    public void Resume() {

        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false ;

    }
    public  void Pause() {

        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void mute() {
        
            AudioListener.pause = !AudioListener.pause;
        
    }
    public void check() {
        if (c.gameObject == null)
        {
            if (checker == false)
            {
                Instantiate(DeathCircle, transform.position, Quaternion.identity);
                DeathCircle.Play();
            }
            checker = true;
        }
        else if (s.gameObject == null)
        {
            if (checker == false)
            {
                Instantiate(DeathCube, transform.position, Quaternion.identity);
                DeathCube.Play();
            }
            checker = true;
        }
        else if (t.gameObject == null)
        {
            if (checker == false)
            {
                Instantiate(DeathTriangle, transform.position, Quaternion.identity);
                DeathTriangle.Play();
            }
            checker = true;
        }
    }
    
}
