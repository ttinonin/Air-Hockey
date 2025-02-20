using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscControll : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll){
        source.Play();
    }

    void RestartGame(){
        ResetBall();
        Invoke("GoBall", 1);
    }

    void ResetBall(){
        rb2d.linearVelocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

}
