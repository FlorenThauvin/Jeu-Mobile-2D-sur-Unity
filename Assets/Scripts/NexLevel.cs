using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NexLevel : MonoBehaviour
{
   public int i = 0;
   public PlayerManager playerManager;
   public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){        // si le joueur touche le drapeau de victoire il va au prochain niveau
            Time.timeScale = 0f;
            playerManager.CompleteLevel();
        }
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(i);
        Time.timeScale = 1f;
    }
}
