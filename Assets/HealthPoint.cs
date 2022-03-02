using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPoint : MonoBehaviour{
    public int maxHP =100;
    public int current;
    public bool isTouchable=false;
    public SpriteRenderer sprite;
    public BarreDeVie HP;
    void Start(){
        current = maxHP;
        HP.SetMaxHealth(maxHP);
    }


    void Update(){
    }
    public void TakeDmg(int dmg){
        if(!isTouchable){
            current -= dmg;
            HP.SetHealth(current);
            isTouchable=true;
            StartCoroutine(Flash());
            StartCoroutine(Delay());
        }
    }

    public IEnumerator Flash(){
        while(isTouchable){
            sprite.color = new Color(1f,1f,1f,0f);
            yield return new WaitForSeconds(0.2f);
            sprite.color = new Color(1f,1f,1f,1f);
            yield return new WaitForSeconds(0.2f);
        }
    }
    public IEnumerator Delay(){
        yield return new WaitForSeconds(2f);
        isTouchable = false;
    }
}
