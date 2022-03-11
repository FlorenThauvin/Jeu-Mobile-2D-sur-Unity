using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canonShoot : MonoBehaviour{
    public Transform firepoint;
    public GameObject bullet;
    float timebetween;
    public float starttime;
    void Start(){
        timebetween=starttime;
    }

    void Update(){
        if(timebetween<=0){
            Instantiate(bullet,firepoint.position,firepoint.rotation);
            timebetween = starttime;
        }
        else {
            timebetween -= Time.deltaTime;
        }
    }
}
