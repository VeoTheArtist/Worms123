using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurn : MonoBehaviour

{
    private PlayerTurnManager Manager;

    public void AssignManager(PlayerTurnManager theManager)
    {
        Manager = theManager;
    }

    public void FireProjectile()
    {
        SetRandomColor();
        Manager.ChangeTurn();
    }

    public void SetRandomColor()
    {
        GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
    }
}
