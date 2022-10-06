using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This Script should be put into Objects other than the player. 

public class ObjectDamage : MonoBehaviour
{

    // how much the Damage amount will be. 
    public int damageAmount = 10;


    // OnCollisionEnter = whenever the player enters the objects collision box. = cannot walk through the collision, but touches It. 
    private void OnCollisionEnter(Collision collision)
    {
         // If player touches collision.  
        if(collision.gameObject.TryGetComponent(out Player_1_Healthbar LifePoint ))
        {
            // here is Losehealth again from "Player_1_Healthbar" script. 
            LifePoint.LoseHealth(damageAmount);
        }

        if (collision.gameObject.TryGetComponent(out Player_2_HealthBar LifePointP2))
        {
            // here is Losehealth again from "Player_1_Healthbar" script. 
            LifePointP2.LoseHealth(damageAmount);
        }
    }
    // OnTriggerEnter = whenever the player Walks into the objects collision box. = can walk through the collision. 
    private void OnTriggerEnter(Collider other)
    {
        // If player walks into collision.
        if (other.gameObject.TryGetComponent(out Player_1_Healthbar LifePoint))
        {
            // same as above.
            LifePoint.LoseHealth(damageAmount);
        }

        if (other.gameObject.TryGetComponent(out Player_2_HealthBar LifePointP2))
        {
            // same as above.
            LifePointP2.LoseHealth(damageAmount);
        }
    }
}
