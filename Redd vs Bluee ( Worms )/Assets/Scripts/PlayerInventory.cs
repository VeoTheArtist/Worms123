using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{

    [SerializeField] private AudioSource DiamondSoundEffect;

    public int NumberOfDiamonds { get; private set; }

    public UnityEvent<PlayerInventory> OnDiamondCollected;

    public void DiamondCollected()
    {
        DiamondSoundEffect.Play();
        NumberOfDiamonds++;
        OnDiamondCollected.Invoke(this);
        
    }

}
