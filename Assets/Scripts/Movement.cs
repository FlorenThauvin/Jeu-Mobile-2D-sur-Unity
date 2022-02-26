using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed =1.5f;
    public float Jump = 5.0f;
    private Rigidbody2D _rigidbody;

    private void Start() {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var move = Input.GetAxis("Horizontal");
        transform.position += new Vector3(move,0,0)* Time.deltaTime * Speed;

        /**if (!Mathf.Approximately(0,move)){
          transform.rotation = move > 0 ? Quaternion.Euler(0,180,0):Quaternion.identity;
        }**/

        if(Input.GetButtonDown("Jump")&& Mathf.Abs(_rigidbody.velocity.y)<0.1f){
            _rigidbody.AddForce(new Vector2(0,Jump),ForceMode2D.Impulse);
        }
    }
}
