using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulet : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector2.left * 0.07f);
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
