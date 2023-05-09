using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootbullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject originalBullet;

     void Update()
     {
         if(Input.GetKeyDown("q"))
         {
             var bullet = Instantiate(originalBullet, transform.position + new Vector3(0.0f, 1.5f,0.0f), transform.rotation) as GameObject;
 
             bullet.transform.Translate(Vector2.right * 20f * Time.deltaTime);
 
             
             
         }
     }
 }