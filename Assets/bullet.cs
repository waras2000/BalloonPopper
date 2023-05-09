using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class bullet : MonoBehaviour
{
 
    //[SerializeField] UnityEngine.AudioSource colclip;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<AudioSource>().playOnAwake=false;
        //GetComponent<AudioSource>().clip = colclip;
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.GetComponent<balloonmovement>()!=null){
            //colclip.Play();
            Destroy(collision.gameObject);
            Destroy(gameObject);
            scoremanager.instance.AddPoint();
            
            int y = SceneManager.GetActiveScene().buildIndex;
            if (y==3){
                SceneManager.LoadScene(0);

            }
            if(y<3){
            SceneManager.LoadScene(y+1);
            }
            
        }
        
        
    }
}
