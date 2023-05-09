using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class scoremanager : MonoBehaviour


{
    public balloonmovement scoreScale;
    
    public static scoremanager instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;
    float score=0;
    float highscore=0;
    string ScoreKey = "Score";
    string HighScoreKey = "HighScore";
    scoremanager scoreSystem;
    public float CurrentScore {get;set;}
    public float CurrentHighScore {get;set;}
    balloonmovement scale;
    
    // Start is called before the first frame update
    private void Awake(){
        CurrentScore = PlayerPrefs.GetFloat(ScoreKey);
        CurrentHighScore = PlayerPrefs.GetFloat(HighScoreKey);
        score = PlayerPrefs.GetFloat(ScoreKey);
        highscore = PlayerPrefs.GetFloat(HighScoreKey);
        instance = this;
    }
    public void SetScore(float score){
        PlayerPrefs.SetFloat(ScoreKey,score);
        
    }
    public void setHighScore(float highscore){
    PlayerPrefs.SetFloat(HighScoreKey,highscore);
    }
    void Start()

    {
        
        int y = SceneManager.GetActiveScene().buildIndex;
        scoreSystem = FindObjectOfType<scoremanager>();
        scale = FindObjectOfType<balloonmovement>();
        Debug.Log(scale.scoreScale);
        if(y==1)
        {
        
        //score = scoreSystem.CurrentScore; 
        score = 0;
        scoreText.text = "Score: " + score ;
        }
        else{
            score = scoreSystem.CurrentScore;
            scoreText.text = "Score " + score;
        }
        highscore = scoreSystem.CurrentHighScore;
        highscoreText.text = "Highscore " + highscore ;
        //highscore = PlayerPrefs.GetInt("highscore", 0);
        //scoreText.text = score.ToString() + " POINTS";
        //highscoreText.text = "HIGHSCORE: " + highscore.ToString();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //highscoreText.text = CurrentHighScore + "";
    }
    public void AddPoint(){
        //int SCALE=0;
        //int.TryParse(scale,out SCALE);
        float multiplier = .50f;
        score+=1-(scale.scoreScale*multiplier);
        scoreText.text = "Score: " + score;
        scoreSystem.SetScore(score);
        //scoreText.text = score.ToString()+ " POINTS";
        //if(highscore<score){
        //PlayerPrefs.SetFloat("highscore",score);
        if(score>highscore){
        highscore=score;
        highscoreText.text = "Highscore: " + highscore;
        scoreSystem.setHighScore(highscore);
        }
        //CurrentHighScore=score;
        //}
    }
}
