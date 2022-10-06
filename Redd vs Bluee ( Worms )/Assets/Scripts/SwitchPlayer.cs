using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SwitchPlayer : MonoBehaviour
{
    [SerializeField] public CinemachineFreeLook ReddCamera1;
    [SerializeField] public CinemachineFreeLook BlueeCamera2;

    public GameObject ReddCamera, BlueeCamera;

    

    public GameObject ReddCharacter, BlueeCharacter;

    int CharacterActivatedOn = 1;

    

    // Start is called before the first frame update
    void Start()
    {
        ReddCharacter.gameObject.SetActive(true);
        BlueeCharacter.gameObject.SetActive(false);
        ReddCamera.SetActive(true);
        BlueeCamera.SetActive(false);



    }



   public void SwitchCharacter()
    {

        switch (CharacterActivatedOn)
        {
            case 1:

                CharacterActivatedOn = 2;

              
                ReddCharacter.gameObject.SetActive(false);
                BlueeCharacter.gameObject.SetActive(true);
                ReddCamera.SetActive(false);
                BlueeCamera.SetActive(true);




                break;

            case 2:

                CharacterActivatedOn = 1;

               
                ReddCharacter.gameObject.SetActive(true);
                BlueeCharacter.gameObject.SetActive(false);
                ReddCamera.SetActive(true);
                BlueeCamera.SetActive(false);



                break;

        }

        





    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCharacter();
        }
    }

}
