using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
/*
public class ActivePlayerManager : MonoBehaviour
{

    

    [SerializeField] private ActivePlayer ReddCharacter;
    [SerializeField] private ActivePlayer BlueeCharacter;
    [SerializeField] private float maxTimePerTurn;
    [SerializeField] private float timeBetweenTurns;
    [SerializeField] private Image clock;
    [SerializeField] private TextMeshProUGUI seconds;

    private ActivePlayer currentPlayer;
    private float currentTurnTime;
    private float currentDelay;

    void Start()
    {
        ReddCharacter.AssignManager(this);
        BlueeCharacter.AssignManager(this);

        currentPlayer = ReddCharacter;
    }

  

    private void Update()
    {
        if (currentDelay <= 0)
        {
            currentTurnTime += Time.deltaTime;
            if (currentTurnTime >= maxTimePerTurn)
            {
                ChangeTurn();
                ResetTimers();
            }
            UpdateTimeVisuals();
        }
        else
        {
            currentDelay -= Time.deltaTime;
        }

    }
    public bool PlayerCanPlay()
    {
        return currentDelay <= 0;
    }

    public ActivePlayer GetCurrentPlayer()
    {
        return currentPlayer;
    }

    public void ChangeTurn()
    {
        if (ReddCharacter == currentPlayer)
        {
            currentPlayer = BlueeCharacter;
        }
        else if (BlueeCharacter == currentPlayer)
        {
            currentPlayer = ReddCharacter;
        }

        ResetTimers();
        UpdateTimeVisuals();
        //ChangeTurn();
    }

    private void ResetTimers()
    {
        currentTurnTime = 0;
        currentDelay = timeBetweenTurns;
    }

    private void UpdateTimeVisuals()
    {
        clock.fillAmount = 1 - (currentTurnTime / maxTimePerTurn);
        seconds.text = Mathf.RoundToInt(maxTimePerTurn - currentTurnTime).ToString();
    }


    
    
}
*/
