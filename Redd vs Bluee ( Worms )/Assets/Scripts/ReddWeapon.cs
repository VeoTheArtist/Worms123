using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ReddWeapon = PlayerWeapon if you wanted to know what that means. 

public class ReddWeapon : MonoBehaviour
{

    
    // BulletPrefab = The Bullet I am using in my Prefab. 
    // ShootingStartPosition = Where the Bullets spawn from on the character. 

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootingStartPosition;


    private void Update()
    {

        // E = Button for shooting. 
        if(Input.GetKeyDown(KeyCode.E)) 
        {
           
            GameObject newBullet = Instantiate(bulletPrefab, shootingStartPosition.position, shootingStartPosition.rotation);
           
            newBullet.GetComponent<BulletEvent>().Initialize();
            
        }
    }


}
