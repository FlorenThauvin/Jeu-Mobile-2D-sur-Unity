using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deploy : MonoBehaviour
{
    public bool deployed = false;
    public Rigidbody2D body;

    void Start(){
        body = GetComponent<Rigidbody2D>();
        body.gravityScale = 35;
    }
    void Update(){}

    public void Parachute()
    {
        if (!deployed) 
        {
            body.gravityScale = 30;
            deployed = true;
        } else {
            body.gravityScale = 12;
            deployed = false;  
        }
    }
}
