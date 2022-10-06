using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1_BulletDamage : MonoBehaviour
{
    public int damageAmount = 10;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.TryGetComponent(out Player_2_HealthBar LifePoint))
        {
            LifePoint.LoseHealth(damageAmount);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Player_2_HealthBar LifePoint))
        {
            LifePoint.LoseHealth(damageAmount);
        }
    }
}
