using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed =1.0f;


    void Update()
    {
        var move = Input.GetAxis("Horizontal");
        transform.position += new Vector3(move,0,0)* Time.deltaTime * Speed;
    }
}
