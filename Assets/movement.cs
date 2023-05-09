using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class movement : MonoBehaviour
{

     Rigidbody2D rb;
     SpriteRenderer sprite;


    [SerializeField] int JUMPHEIGHT = 1;
    [SerializeField] float HORIZONTALDIRECTIONSPEED = 1.0f;
    private bool isJumping;
    [SerializeField]
    
    //private AudioMixer Mixer;
    private AudioSource AudioSource;


    //private AudioMixMode MixMode;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        //Mixer.SetFloat("Volume",Mathf.Log10(PlayerPrefs.GetFloat("Volume",1)*20));

    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(dirX * HORIZONTALDIRECTIONSPEED, rb.velocity.y);
        //if(dirX > 0)
        //{
        //    sprite.flipX = true;
       // }
        //if (dirX < 0)
        //{
        //    sprite.flipX = true;
        //}

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.velocity = new Vector2(rb.velocity.x , JUMPHEIGHT);
            isJumping = true;
        }
    }
    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Ground")){
            isJumping = false;
        }
        
    }
}
