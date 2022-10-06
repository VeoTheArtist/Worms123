using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_2_HealthBar : MonoBehaviour
{

    [SerializeField] private AudioSource HealthSoundEffect;
    [SerializeField] private AudioSource DamagedSoundEffect;


    public Image fillBarP2;
    public float LifePointP2;

    // 100% health = 1 fill amount
    // 45% = 0.45 fill amount. 


    public void LoseHealth(int value)
    {
        // Do nothing for now when the player is dead.
        if (LifePointP2 <= 0)
            return;
        //reduce Hitpoints = the amount of value. 
        DamagedSoundEffect.Play();
        LifePointP2 -= value;
        //Refresh UI fullbar = It updates the Health bar. 
        fillBarP2.fillAmount = LifePointP2 / 100;
        // Check whenever the players health is 0 or lower = dead. The Debug should also say this message when you are dead, 
        if (LifePointP2 <= 0)
        {
            Destroy(gameObject);
            Debug.Log("You are now Dead");
            return;
        }
    }

    public void GetHealth(int value)
    {
        // Do nothing for now
        if (LifePointP2 <= 0)
            return;
        //Increase Hitpoints
        HealthSoundEffect.Play();
        LifePointP2 += value;
        //Refresh UI fullbar
        fillBarP2.fillAmount = LifePointP2 / 100;
    }

    private void Update()
    {
        // Key for checking if you can take damage. 
        if (Input.GetKeyDown(KeyCode.U))
            LoseHealth(10);

        // key for checking if you can increase health. 
        if (Input.GetKeyDown(KeyCode.I))
            GetHealth(10);

        // Checking whenever you are above 110 health, you will lose 10 back. 
        if (LifePointP2 >= 110)
            LoseHealth(10);
    }
}
