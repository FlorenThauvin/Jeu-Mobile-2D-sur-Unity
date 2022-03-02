using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;
    private Transform target;
    public int dmg;
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
    private void OnCollisionEnter2D(Collision2D other) {        // fonction qui permet a l'ennemi de faire des dégats si il rentre en collision
        if(other.transform.CompareTag("Player")){
            HealthPoint HP = other.transform.GetComponent<HealthPoint>();
            HP.TakeDmg(dmg);
        }
    }
}
