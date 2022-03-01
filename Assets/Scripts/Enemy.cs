using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;
    private Transform target;

    public SpriteRenderer sprite;
    private int destination=0;
    void Start(){
        target = waypoints[0];
    }

    void Update(){
        Vector3  direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime , Space.World);

        if(Vector3.Distance(transform.position,target.position) < 0.3f){
            destination = (destination+1) % waypoints.Length;
            target = waypoints[destination];
            sprite.flipX = !sprite.flipX;
        }
    }
}
