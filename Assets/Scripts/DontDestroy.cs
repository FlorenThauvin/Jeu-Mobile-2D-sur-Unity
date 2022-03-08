
using UnityEngine;

public class DontDestroy : MonoBehaviour{
    public GameObject[] obj;
void Awake() {
       foreach (var element in obj){
           DontDestroyOnLoad(element);
       }
    }

}
