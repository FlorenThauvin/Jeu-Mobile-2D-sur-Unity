using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NexLevel : MonoBehaviour
{
   public int i = 0;
   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            SceneManager.LoadScene(i);
        }
    }
}
