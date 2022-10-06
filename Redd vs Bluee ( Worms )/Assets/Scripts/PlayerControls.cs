using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public ParticleSystem dust;

    //[SerializeField] private float speed = 5f;
    public float speed;
    public float rotationSpeed;
    public float JumpSpeed;
    public float JumpButtonDelay;

   private CharacterController characterController;

   [SerializeField] private AudioSource JumpSoundEffect;

    [SerializeField] private AudioSource DeadSoundEffect;

    [SerializeField] private Transform Cameratransform;

    //[SerializeField] private ActivePlayerManager manager;



    private float ySpeed;
    private float originalStepOffset;
    // private float with ? means It will either be float number value or no value at all. 
    private float? lastGroundedTime;
    private float? jumpButtonPressedTime;


    [SerializeField] private Rigidbody characterbody;
    public float LifePoint;

    // I am using the characterController as a way to add Collision to the player later on. 

    void Start()

    {
        characterController = GetComponent<CharacterController>();
        originalStepOffset = characterController.stepOffset;
        LifePoint = 100;
    }





    // Update is called once per frame

    // Quaternions are used to represent rotations. So I will be using them for the rotation for the character. 
    void Update()
    {
       

        //currentPlayer.transform.Rotate(Vector3.up);

        float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

        
        

            Vector3 movementDirection = new Vector3(horizontalInput, 0.0f, verticalInput);
            float magnitude = movementDirection.magnitude;
            magnitude = Mathf.Clamp01(magnitude) * speed;
       

            // This line is confusing, but It help? - when you want the camera to rotate. 
            movementDirection = Quaternion.AngleAxis(Cameratransform.rotation.eulerAngles.y, Vector3.up) * movementDirection;
            movementDirection.Normalize();




            ySpeed += Physics.gravity.y * Time.deltaTime;


        if (Input.GetKeyDown(KeyCode.Space) && characterbody.velocity.y <= 0.05f)
        {
            Jump();
        }

      
        

        // If the character is grounded, Then I am making sure that there can be a delay for the jump, 
        //if you wanna jump when you are about to fall of the platform. 

        // character Offset = making sure my character has some momentun in the air, when falling. Otherwise, it will drop really quickly. 

        if (characterController.isGrounded)
            {
                lastGroundedTime = Time.time;
            
        }

            if (Input.GetButtonDown("Jump"))
            {
                jumpButtonPressedTime = Time.time;
                JumpSoundEffect.Stop();
            }


            if (Time.time - lastGroundedTime <= JumpButtonDelay)
            {
                characterController.stepOffset = originalStepOffset;
                ySpeed = -0.5f;


                if (Time.time - jumpButtonPressedTime <= JumpButtonDelay)
            {
                    ySpeed = JumpSpeed;
                    jumpButtonPressedTime = null;
                lastGroundedTime = null;
                CreateDust();
                JumpSoundEffect.Play();
            }
            }
            else
        {
                characterController.stepOffset = 0;
            
        }

            // 


            Vector3 velocity = movementDirection * magnitude;
            velocity.y = ySpeed;
            characterController.Move(velocity * Time.deltaTime);



            //transform.Translate(movementDirection * magnitude *  speed * Time.deltaTime, Space.World);


            if (movementDirection != Vector3.zero)
            {
                // Quaternion is for Rotation only as what I heard. 
                Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

                transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            }


        





            /*
            if (Input.GetAxis("Horizontal") != 0)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"));
            }

            if (Input.GetAxis("Vertical") != 0)
            {
                transform.Translate(Vector3.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));
            }
            */

            
            

            

            // If lifepoint ( for the player ) is 0, The player will die and get destroyed. Lifepoint is linked to the Healthbar script. 
            if (LifePoint == 0)
            {
                DeadSoundEffect.Play();
                Destroy(gameObject);
                //DeadSoundEffect.Play();

            }








        }

        private void Jump()
        {

        //characterbody.AddForce(Vector3.up * 3000f);
        CreateDust();
            characterbody.velocity = Vector3.up * 7f;
        }
    
    
    void CreateDust()
    {
        dust.Play();
    }

        private void OnApplicationFocus(bool focus)
        {
            if (focus)
            {
                // will lock the cursor to the center of the game view. 
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                // It means, this like is not modified. = It won't lock to the center of the game screen. 
                Cursor.lockState = CursorLockMode.None;
            }
            
        }
    
        
    
    





}

    

