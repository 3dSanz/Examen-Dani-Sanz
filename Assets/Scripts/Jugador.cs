using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    SpriteRenderer sRend;
    BoxCollider2D bC2d;
    Rigidbody2D rB2d;
    public float velocidad = 5.5f;
    public float salto = 8f;
    float movimiento;
    DetectorSuelo dSuelo;


    // Start is called before the first frame update
    void Start()
    {
        sRend = GetComponent<SpriteRenderer>();
        bC2d = GetComponent<BoxCollider2D>();
        rB2d = GetComponent<Rigidbody2D>();
        dSuelo = GameObject.Find("DetectorSuelo").GetComponent<DetectorSuelo>();

    }

    // Update is called once per frame
    void Update()
    {
        movimiento = Input.GetAxis("Horizontal");
        if(movimiento > 0)
        {
            sRend.flipX = false;
        }
        if(movimiento < 0)
        {
            sRend.flipX = true;
        }
 if (Input.GetButtonDown("Jump") && dSuelo.enSuelo)
           {
               rB2d.AddForce(Vector2.up * salto, ForceMode2D.Impulse);
           }
    }

    private void FixedUpdate() {
        rB2d.velocity = new Vector2 (movimiento*velocidad, rB2d.velocity.y);
    }

}
