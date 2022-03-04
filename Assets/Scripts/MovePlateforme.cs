using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlateforme : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;
    private Transform target;
    private int destination=0;
    void Start(){
        target = waypoints[0];
    }

    void Update(){
        int taille = waypoints.Length;
        Vector3  direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime , Space.World);
        if(Vector3.Distance(transform.position,target.position) < 0.3f){
            destination = (destination+1) % taille;
            target = waypoints[destination];
            }
        }
}