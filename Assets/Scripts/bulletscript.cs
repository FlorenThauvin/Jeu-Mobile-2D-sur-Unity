using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour{
    public float speed;
    private float time;
    Rigidbody2D body;
    void Start(){
        body = GetComponent<Rigidbody2D>();
        body.velocity = transform.right * - speed;
    }

    void Update(){
        if(time>=2.8){
            Destroy(gameObject); 
        }
        else { time+=Time.deltaTime;}
    }
}
