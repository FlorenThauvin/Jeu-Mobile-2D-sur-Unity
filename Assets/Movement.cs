using UnityEngine;

public class Movement : MonoBehaviour{
    public float moveSpeed;         // variable pour la vitesse
    public float jump;              // variable pour le saut
    public bool isJumping;          // boolean pour savoir si il saute
    public bool isGrounded;         // boolean pour savoir si il touche le sol
    public Rigidbody2D body;          // rigibody
    public Transform droite;        // position du pied droit
    public Transform gauche;        // position du pied gauche
    private Vector3 velocity = Vector3.zero;    // vecteur pour la velocité

    void FixedUpdate(){
        isGrounded = Physics2D.OverlapArea(gauche.position,droite.position);            // pour vérifier si il touche le sol et empeche les doubles sauts  
        float moveRight = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;     // si il appuie les touches de déplacement on multiplue l'axe horizontal par la speed et deltaTime
        if(Input.GetButtonDown("Jump")&& isGrounded){isJumping = true;}                 // si il appuie sur la touche "Jump" et touche le sol alors is Jumping passe à vrai
        Move(moveRight);
    }

    void Move( float _moveRight){
        Vector3 target = new Vector2(_moveRight, body.velocity.y);
        body.velocity = Vector3.SmoothDamp(body.velocity,target, ref velocity, 0.05f);
        if(isJumping){              // si isJumping est vrai alors on ajoute une force sur l'axe Y qui correspont à jump et on passe isJumping à false
            body.AddForce(new Vector2(0.0f,jump));
            isJumping = false;
        }
    }
}
