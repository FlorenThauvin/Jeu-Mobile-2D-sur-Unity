using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            Destroy(transform.parent.parent.gameObject);        // si le joueur touche la hitbox la cible est détruite
        }
    }
}
