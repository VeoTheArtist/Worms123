using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Script to put into your Player Character
public class Health : MonoBehaviour
{
    // Max = The Total amount of Hhealth point your character has. ( can be changed in Unity Inspector.)
    public int MaxHealth = 10;
    // Current Health = how much health you have right now. 
    public int currentHealth;

 
    
 
    // Start is called before the first frame update
    void Start()
    {
        // I want the Current health to be the total health "MaxHealth" has. 
        currentHealth = MaxHealth;

    }

   
}
