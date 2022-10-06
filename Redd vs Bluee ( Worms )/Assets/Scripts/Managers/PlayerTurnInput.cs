using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurnInput : MonoBehaviour
{
    [SerializeField] private PlayerTurnManager Manager;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float walkingSpeed;

    void Update()
    {
        if (!Manager.PlayerCanPlay())
        {
            return;
        }
        if (Input.GetAxis("Horizontal") != 0)
        {
            PlayerTurn currentPlayer = Manager.GetCurrentPlayer();
            currentPlayer.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), Space.World);
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            PlayerTurn currentPlayer = Manager.GetCurrentPlayer();
            currentPlayer.transform.Translate(currentPlayer.transform.forward * walkingSpeed * Time.deltaTime * Input.GetAxis("Vertical"), Space.World);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            PlayerTurn currentPlayer = Manager.GetCurrentPlayer();
            currentPlayer.GetComponent<BulletEvent>().Initialize();
        }
    }
}
