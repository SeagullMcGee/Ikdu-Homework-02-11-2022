using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float SidewaysForce = 200f;
    public Transform GroundCheckTransform;
    public Rigidbody rb;
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    
    private int HowManyJumps;

    private string CharacterName = "kevin";

    private int Level = 1;
   

    
    // Start is called before the first frame update
    void Start()
    {
        playerInfo();
    }
    void playerInfo()
    {
        Debug.Log("What is the name of the character?");
        Debug.Log(CharacterName);
        Debug.LogFormat("What was the characters's name again? {0}, and what level does he have {1}", CharacterName, Level);
        
    }
    
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
            
            HowManyJumps = HowManyJumps + 1;
        
        }
            horizontalInput = Input.GetAxis("Horizontal");
            Debug.Log(HowManyJumps);
       
        
    
    }

    private void FixedUpdate()
    {
       if (Physics.OverlapSphere(GroundCheckTransform.position, 0.1f).Length == 1)
        {
            return;
        }
      
        if (jumpKeyWasPressed)
        {
            rb.AddForce(Vector3.up * 6, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        {
            rb.velocity = new Vector3(horizontalInput, rb.velocity.y, 0);
        }
    }

   

}

