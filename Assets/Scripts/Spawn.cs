using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject[] pre;
    [SerializeField] float spawn2 = 0.5f;
    [SerializeField] float min;
    [SerializeField] float max;
    void Start()
    {
        StartCoroutine(ObjSpawn());
    }

    IEnumerator ObjSpawn(){
        while(true){
            var wanted = Random.Range(min,max);
            var position = new Vector3(wanted,transform.position.y);
            GameObject gO = Instantiate(pre[Random.Range(0,pre.Length)],position,Quaternion.identity);
            yield return new WaitForSeconds(spawn2);
            Destroy(gO,5f);
        }
    }

}
