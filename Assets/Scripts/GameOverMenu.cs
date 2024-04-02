using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour
{

    public GameObject gameOver;
    //public PlayerController playerScore;
     public bool isActive;
    [SerializeField] private Text timer;
    public TimeCounter timmmy;
    public int score =100;
    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      if(score <= 0)
        {
            stopGame();
            isActive = true;
        } 

    }
    
    public void restartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
        //gameOver.SetActive(false);
        score = 100;
        isActive = false;
    }

    public void stopGame()
    {
        gameOver.SetActive(true);
        timer.text = timmmy.timer.ToString();
        Time.timeScale = 0f;
        
    }

   


}
