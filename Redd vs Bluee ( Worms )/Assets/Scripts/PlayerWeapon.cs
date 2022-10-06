using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] public float bulletSpeed = 10f;
    public Transform bulletFire;
    public GameObject bulletPrefabs;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            var bullet = Instantiate(bulletPrefabs, bulletFire.position, bulletFire.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletFire.forward * bulletSpeed;
        }

        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(bulletPrefabs, bulletFire.position, bulletFire.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletFire.forward * bulletSpeed;
        }
    }
}