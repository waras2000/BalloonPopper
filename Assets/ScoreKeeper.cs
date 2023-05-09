using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] int score = 0;
    //[SerializeField] Text Scoretext;

    public void AddPoints(int points)
    {
        //score += points;
        //Debug.Log("score: " + score);
    }


    public int GetScore()
    {
        return score;
    }
}
