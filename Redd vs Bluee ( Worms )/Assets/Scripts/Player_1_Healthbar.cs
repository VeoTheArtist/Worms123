using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// this Script will be added into your character as well!

// Player_1_Healthbar = It tells me the UI I have based on the damage or healing I get. 
public class Player_1_Healthbar : MonoBehaviour
{

    [SerializeField] private AudioSource HealthSoundEffect;
    [SerializeField] private AudioSource DamagedSoundEffect;
    


    // Fillbar = the line of the UI healthbar. The bar Itself. 
    public Image fillBar;


    // LifePoint or Healthpoint or PlayerHealth... doesn't really matter what you name It here, as long as you have a name for It. 
    // Lifepoint = The Players Health. 
    public float LifePoint;

    // 100% health = 1 fill amount. There is a option in the inspector to add another point into the fillbar. If there is 2 instead of 1. The Number would be 200% if 2. 
    // 45% = 0.45 fill amount. 



    // LoseHealth = the code whenever I lose health. 
    public void LoseHealth(int value)
    {


        // Do nothing for now when the player is dead.
        if (LifePoint <= 0)
        return;

        //reduce Hitpoints = the amount of value. 
        DamagedSoundEffect.Play();
        LifePoint -= value;

        //Refresh UI fullbar = It updates the Health bar. 
        fillBar.fillAmount = LifePoint / 100;

        // Check whenever the players health is 0 or lower = dead. The Debug should also say this message when you are dead, 
        if(LifePoint<=0)
        {
            Destroy(gameObject);
            // Check in game if this message appears if your character gets destroyed. 
            Debug.Log("You are now Dead");
            return;
        }
    }


    // same code as "LoseHealth" but opposite. Instead of losing, you gain health. 
    public void GetHealth(int value)
    {
        // Do nothing for now
        if (LifePoint <= 0)
            return;
        //Increase Hitpoints
        HealthSoundEffect.Play();
        LifePoint += value;
        //Refresh UI fullbar
        fillBar.fillAmount = LifePoint / 100;
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
        if (LifePoint >= 110)
            LoseHealth(10);
    }






}


   
    


    

   


