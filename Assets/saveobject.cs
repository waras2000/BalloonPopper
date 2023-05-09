using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class saveobject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        DontDestroyOnLoad(gameObject);
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        int x = SceneManager.GetActiveScene().buildIndex;
        if (x==0){
            Destroy(gameObject);
        }
    }
}
