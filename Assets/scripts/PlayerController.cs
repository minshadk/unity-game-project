using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float yVelocity;
    public float speed;
    private float dirX;
    private BoxCollider2D  col;
    public LayerMask groundLayer;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        col = GetComponent<BoxCollider2D>();
        // Debug.log("hi")

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && isGrounded() ){
            rb.velocity = new Vector2(0,yVelocity);
        }

        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(1 * speed,rb.velocity.y);
    }

    private bool isGrounded() {
        return Physics2D.BoxCast(col.bounds.center,col.bounds.size,0,Vector2.down,0.2f,groundLayer);

        // (postion,size,angle,whic direction,distance,layername)
    }
}
