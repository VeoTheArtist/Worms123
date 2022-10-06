using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//BulletEvent = The projectile Script
// I am using Rigidbody on my bullets, so you might not want that in yours. 

public class BulletEvent : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody BulletBody;
    private bool isActive;

    public void Initialize()
    {
        isActive = true;
        BulletBody.AddForce(gameObject.transform.forward * 750f + transform.up * 225f);
        
    }


    void Update()
    {
        if (isActive)
        {
            
           

        }
    }


    // Down below means whenever the bullets hit something It will destroy all the objects I have created. - 
    // - which is why I have another scrpt for Undestroyable objects. 

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collisionObject = collision.gameObject;
        UndestroyableField destruction = collisionObject.GetComponent<UndestroyableField>();
        if ( destruction == null)
        {
            Destroy(collisionObject);
        }


        
      
    }

}
