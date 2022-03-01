using UnityEngine;

public class Movement : MonoBehaviour{
    public float moveSpeed;         // variable pour la vitesse
    public float jump;              // variable pour le saut
    public Rigidbody2D body;          // rigibody
    private Vector3 velocity = Vector3.zero;    // vecteur pour la velocité
    public Animator animator;
    public SpriteRenderer sprite;

    void FixedUpdate(){ 
        float moveRight = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;     // si il appuie les touches de déplacement on multiplue l'axe horizontal par la speed et deltaTime
        Move(moveRight);
        Flip(body.velocity.x);
        float absVelocity = Mathf.Abs(body.velocity.x);
        animator.SetFloat("Speed",absVelocity);

    }

    void Update() {
        if(Input.GetButtonDown("Jump")&& Mathf.Abs(body.velocity.y)<0.1f){      // si il appuie la touche Jump , on ajoute une force sur l'axe Y d'un motant de la force donné en paramètre
            body.AddForce(new Vector2(0,jump),ForceMode2D.Impulse);
        }
    }

    void Move( float _moveRight){
        Vector3 target = new Vector2(_moveRight, body.velocity.y);
        body.velocity = Vector3.SmoothDamp(body.velocity,target, ref velocity, 0.05f);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Coins")){
            Destroy(other.gameObject);
        }
    }

    void Flip(float _velocity){
        if(_velocity>0.1f){sprite.flipX=false;}
        else if(_velocity<-0.1f){sprite.flipX=true;}

    }
}
