using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentScript : MonoBehaviour
{

    private Rigidbody2D rb;
    [SerializeField] private GameObject bullet;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(5, 0);
        }
        if(Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-5, 0);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(transform.up * 300);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
}
