using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpawner : MonoBehaviour
{
    public GameObject smallHeart;

    void Update()
    {
     
        if(Input.GetKeyDown(KeyCode.E))
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-3, 3), 1, Random.Range(-55, -48));
            Instantiate(smallHeart, randomSpawnPosition, Quaternion.identity);
        }

    }
}
