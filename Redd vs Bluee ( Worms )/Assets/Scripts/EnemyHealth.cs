using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int MaxHealth = 10;
    public int currentHealth;




    // Start is called before the first frame update
    void Start()
    {

        currentHealth = MaxHealth;

    }
}
