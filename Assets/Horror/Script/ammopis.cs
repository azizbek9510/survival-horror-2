using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammopis : MonoBehaviour
{ 
	
	private damagepis shooter;
	private magazinpistolet ammo;
    
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{    
		ammo=FindObjectOfType<magazinpistolet>();
		
	}
    
	// Sent each frame where another object is within a trigger collider attached to this object (2D physics only).
	protected void OnTriggerEnter(Collider other)
	{
		
		if(other.gameObject.tag=="Player"){
			
			Debug.Log("AMMO");
			
			
		
				ammo.Magazinammo+=6;
			
			
			
			
				
			
	       
				
				Destroy(gameObject, 0.1f);
			
		}
		}
}
