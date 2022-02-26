using UnityEngine;

public class Movement : MonoBehaviour{
    public float moveSpeed;
    public float jump;
    public bool isJumping;
    public bool isGrounded;
    public Rigidbody2D rb;
    public Transform droite;
    public Transform gauche;
    private Vector3 velocity = Vector3.zero;

    void FixedUpdate(){
        isGrounded = Physics2D.OverlapArea(gauche.position,droite.position);
        float moveRight = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        if(Input.GetButtonDown("Jump")&& isGrounded){isJumping = true;}
        Move(moveRight);
    }

    void Move( float _moveRight){
        Vector3 target = new Vector2(_moveRight, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity,target, ref velocity, 0.05f);

        if(isJumping){
            rb.AddForce(new Vector2(0.0f,jump));
            isJumping = false;
        }
    }
}
