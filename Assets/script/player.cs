using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player : MonoBehaviour
{
    public bool isGrounded;
    public float speed ;
    private Rigidbody2D rb;
    private float inputHorizontal;
    private float inputVertical;
    public float distance;
    public LayerMask Ground;
    private bool isClimbing;
    public float jump = 80f;
    public static int numberOfCoins;
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  

    }

    private void Update()
    {

        Debug.Log(numberOfCoins);


        if (Input.GetButtonDown("Jump")&& isGrounded)
            rb.velocity = new Vector2(rb.velocity.x, jump);

        if (Input.GetAxis("Horizontal") > 0)
        {
            this.transform.GetComponent<SpriteRenderer>().flipX = false;
        }

        else if (Input.GetAxis("Horizontal") < 0)
        {
            this.transform.GetComponent<SpriteRenderer>().flipX = true;
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {

       // transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, 0)*Time.fixedDeltaTime*speed);
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(inputHorizontal *speed, rb.velocity.y);

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position , -transform.up, distance, Ground );

        if (hitInfo.collider != null)
        {
            isGrounded = true;

        }
        else
        {
            isGrounded = false;
                
            
        }


        
      
    }
}





