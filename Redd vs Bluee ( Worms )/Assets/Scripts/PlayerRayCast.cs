using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRayCast : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.P))
        {
            RaycastHit result;
            bool ItWasHit = Physics.Raycast(transform.position, transform.forward, out result, Mathf.Infinity);

            Debug.DrawRay(transform.position, transform.forward * 50f, Color.red, 0.05f);

            if (ItWasHit)
            {
                result.collider.gameObject.GetComponent<MeshRenderer>().material.color = GetRandomColor();
            }
            
        }
    }

    private Color GetRandomColor()
    {
        Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        return color;
    }
}
