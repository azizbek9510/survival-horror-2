using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{ 
	
	private shoot shooter;
	
    
	// Sent each frame where another object is within a trigger collider attached to this object (2D physics only).
	protected void OnTriggerEnter(Collider other)
	{
		
		if(other.gameObject.tag=="Player"){
			
			Debug.Log("AMMO");
			shooter = FindObjectOfType<shoot>();
			if(shooter!=null)
				shooter.Magazinammo+=6;
			
			
			
			
				
			
	       
				
				Destroy(gameObject, 0.1f);
			
		}
		}
}
