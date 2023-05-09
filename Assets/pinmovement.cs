using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinmovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float speedMultiplier = 5;
    void Update()
    {
          transform.Translate(Vector2.right * Time.deltaTime * speedMultiplier);

        
    }
}
