using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
	//public GameObject game;
	public float healt=50f;
	private AImonster deads;
	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		//anim=GetComponent<Animator>();
	}
	
	// Update is called every frame, if the MonoBehaviour is enabled.
	protected void Update()
	{
		
	}
	
	public void TakeDamage (float amount){
		
		healt-=amount;
		if(healt<=0f){
			if(deads!=null)
				deads.kill();
			//Debug.Log("DEAD");
			Die();
		}
		
	}
	
	void Die(){
		
		
		
		
	
			
		//Destroy(gameObject,5f);
	}
}
