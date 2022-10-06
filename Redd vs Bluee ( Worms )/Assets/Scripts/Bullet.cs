using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private bool collided;
    public float life = 3;

    void Awake()
    {
        Destroy(gameObject, life);
    }
    
    /*

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag != "Bullet" && collider.gameObject.tag != "Player" && !collided)
        {
            collided = true;
            Destroy(gameObject);
        }
    }
    */
}