using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2_BulletDamage : MonoBehaviour
{
    public int damageAmount = 10;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.TryGetComponent(out Player_1_Healthbar LifePoint))
        {
            LifePoint.LoseHealth(damageAmount);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Player_1_Healthbar LifePoint))
        {
            LifePoint.LoseHealth(damageAmount);
        }
    }
}
