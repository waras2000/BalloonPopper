using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    
   private void OnTriggerEnter2D(Collider2D other) {
    Destroy(gameObject);
   }
   
}
