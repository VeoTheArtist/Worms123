using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon1 : MonoBehaviour
{
    [SerializeField] private int weaponDamage;
    [SerializeField] private Transform weaponBarrel;
    [SerializeField] private LineRenderer lineRenderer;


    public void ShootBullets()
    {

        RaycastHit result;
        bool itWasHit = Physics.Raycast(weaponBarrel.position, transform.forward, out result, Mathf.Infinity);

        if (itWasHit)
        {
            Player_1_Healthbar player_1_Healthbar = result.collider.GetComponent<Player_1_Healthbar>();
            if (player_1_Healthbar != null)
            {
                player_1_Healthbar.LoseHealth(weaponDamage);
            }
            lineRenderer.SetPosition(1, result.point);
        }
        else
        {
            lineRenderer.SetPosition(1, weaponBarrel.position + transform.forward * 50);
        }

    }



}
