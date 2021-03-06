using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
	public CharacterController controller;
	
	public Transform groundCheck;
	
	public LayerMask groundMask;
	
	private camerashake shake;

	
	public float speed =5f;
	public float gravity = -9.8f;
	public float groundDistans = 0.4f;
	
	public float jumpHeight = 3f;
	
	
	Vector3 velocity;
	bool isGrounded;
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
	{
		
		
		isGrounded = Physics.CheckSphere(groundCheck.position,groundDistans, groundMask);
		if (isGrounded && velocity.y < 0){
			velocity.y = -2f;
		}
		
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
	    
		if (Input.GetButtonDown("Jump") && isGrounded)
		{
			velocity.y= Mathf.Sqrt(jumpHeight * -2 * gravity);
		}
		
		if (Input.GetKey("left ctrl"))
		{
			controller.height = 1f;
		} else
		{
			controller.height = 2f;
		}
		shake = FindObjectOfType<camerashake>();
		if (Input.GetKey("left shift"))
		{
			shake.run=true;
			speed = 6f;
		} else
		{
			shake.run=false;
			speed = 3f;
		}
	    
		if(z>0||z<0){
			shake.anim.SetBool("move",true);
		}else{
			shake.anim.SetBool("move",false);
		}
	    
	    Vector3 move = transform.right * x + transform.forward * z;
	    controller.Move(move * speed * Time.deltaTime);
	    velocity.y += gravity * Time.deltaTime;
		controller.Move(velocity * Time.deltaTime);
	    
    }
}
