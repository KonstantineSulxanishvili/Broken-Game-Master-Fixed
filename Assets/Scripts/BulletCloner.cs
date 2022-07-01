using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCloner : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    
    void Start()
    {
        InvokeRepeating("CreateBall", 2f, 2f);
    }

    void CreateBall()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
