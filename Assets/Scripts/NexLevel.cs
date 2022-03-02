using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NexLevel : MonoBehaviour
{
   public int i = 0;
   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){        // si le joueur touche le drapeau de victoire il va au prochain niveau
            SceneManager.LoadScene(i);
        }
    }
}
