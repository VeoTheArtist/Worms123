using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{

   

    public int HealthPoints = 10;

    private void OnCollisionEnter(Collision collision)
    {
      
        if (collision.gameObject.TryGetComponent(out Player_1_Healthbar LifePoint))
        {
            LifePoint.GetHealth(HealthPoints);
        }

        if (collision.gameObject.TryGetComponent(out Player_2_HealthBar LifePointP2))
        {
            LifePointP2.GetHealth(HealthPoints);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Player_1_Healthbar LifePoint))
        {
            
            LifePoint.GetHealth(HealthPoints);
            Destroy(gameObject);
        }

        if (other.gameObject.TryGetComponent(out Player_2_HealthBar LifePointP2))
        {

            LifePointP2.GetHealth(HealthPoints);
            Destroy(gameObject);
        }
    }

    
    
}


/*
    if  (collision.gameObject.CompareTag("Player"))
      {
          Player_1_Healthbar LifePoint = collision.gameObject.GetComponent<Player_1_Healthbar>();
          LifePoint.LoseHealth(damageAmount);
      } 
    */
