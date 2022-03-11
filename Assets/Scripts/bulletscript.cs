using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour{
    public float speed;
    private float time;
    public float destroy;
    Rigidbody2D body;
    void Start(){
        body = GetComponent<Rigidbody2D>();
        body.velocity = transform.right * - speed;
    }

    void Update(){
        if(time>=destroy){
            Destroy(gameObject); 
        }
        else { time+=Time.deltaTime;}
    }
}
