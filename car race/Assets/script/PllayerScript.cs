using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PllayerScript : MonoBehaviour
{
    public float speed = 15f;
    public Rigidbody2D rb;
   // public float mapeWide = 5f;

    // Update is called once per frame
    void Update()
    { 
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

        rb.MovePosition(rb.position + Vector2.right * x) ;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<GameManager>().EndGame();
      
    }
}
