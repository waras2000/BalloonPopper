using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class balloonmovement : MonoBehaviour
{
    public Vector3 pointB;
    [SerializeField] TextAlignment t;
    ScoreKeeper ScoreKeeper;
    private TMP_Text scoreText;
    public float scoreScale;    
   
    IEnumerator Start()
    {
        var pointA = transform.position;
        while(true)
        {
            yield return StartCoroutine(MoveObject(transform, pointA, pointB, 3.0f));
            yield return StartCoroutine(MoveObject(transform, pointB, pointA, 3.0f));
        }
    }
   
    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
    {
        var i= 0.0f;
        var rate= 1.0f/time;
        while(i < 1.0f)
        {
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
        }
    }
    
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
     //   Debug.Log("Player Hit");
     //   ScoreKeeper.AddPoints(10);
        //T.text = "Score " + ScoreKeeper.GetScore()
      
       // Destroy(gameObject);
        //Destroy(gameObject, 1); //takes an optional second parameter for number of seconds before the destroying
    //}
    float scale = .5f;
    void Update(){
        int x = SceneManager.GetActiveScene().buildIndex;
        if (x==1){
        scale+=0.0001f;
        }
        if(x==2){
            scale+=0.0002f;
        }
        if(x==3){
            scale+=0.0003f;
        }
        transform.localScale = new Vector2(scale,scale);
        scoreScale=scale;
        if(scale>=2f){
            Destroy(gameObject);
            int y = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(y);
        }
    }
}
 