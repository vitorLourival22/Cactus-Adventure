using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{   
  
    public float speed;
    public float jumpForce;
    private Rigidbody2D rb;
    

    private bool isjump;

    private Animator anim;
    
    
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
       anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      movent();
      jump();
    }
    void movent()
    {
      float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 dir = new Vector2(moveHorizontal,0f);
        transform.position += dir * speed * Time.fixedDeltaTime;

      if (moveHorizontal != 0)
      {
        anim.SetBool("walk", true);
        anim.SetBool("idle",false);

        if (moveHorizontal > 0 && transform.localScale.x < 0)
        {
          FlipChar();
        }
        else if (moveHorizontal < 0 && transform.localScale.x > 0)
        {
          FlipChar();
        }
      }
      else
      {
        anim.SetBool("walk", false);
        anim.SetBool("idle",true);
      }
    }
    void FlipChar()
    {
      Vector3 scale = transform.localScale;
      scale.x *= -1;
      transform.localScale = scale;
    }
    void jump()
    {
      if (Input.GetButtonDown("Jump") && !isjump)
      {
       rb.AddForce(new Vector2(0f,jumpForce),ForceMode2D.Impulse);
      }
    }
     private void OnCollisionEnter2D(Collision2D collision)
    {
    Debug.Log("no ar");
    isjump = false;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
    Debug.Log("no chao");
    isjump = true;
    }
}

