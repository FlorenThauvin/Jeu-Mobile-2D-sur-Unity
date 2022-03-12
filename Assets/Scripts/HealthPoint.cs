using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthPoint : MonoBehaviour{
    public int maxHP =100;
    public int current;
    public bool isTouchable=false;
    public SpriteRenderer sprite;
    public int death;
    public BarreDeVie HP;

    void Start(){
        current = maxHP;
        HP.SetMaxHealth(maxHP);
    }


    void Update(){
        if(current <= 0 || GameObject.FindGameObjectsWithTag("Player")[0].transform.position.y <= death)
        {
            PlayerManager.isGameOver = true;
            //gameObject.SetActive(false);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

  

    public void TakeDmg(int dmg){
        if(!isTouchable){
            current -= dmg;
            HP.SetHealth(current);
            isTouchable=true;                       
            StartCoroutine(Flash());                // on démarre le flash
            StartCoroutine(Delay());                // on démarre le delay
        }
    }

    public IEnumerator Flash(){
        while(isTouchable){                             // si il est intouchable il devient invisible toute les 0.2
            sprite.color = new Color(1f,1f,1f,0f);
            yield return new WaitForSeconds(0.2f);      // delai de 0.2 s entre chaque phase
            sprite.color = new Color(1f,1f,1f,1f);
            yield return new WaitForSeconds(0.2f);
        }
    }
    public IEnumerator Delay(){
        yield return new WaitForSeconds(2f);            // durée de l'invincibilité
        isTouchable = false;                            // il redevient touchable après 2s
    }
}
