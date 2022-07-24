using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
	//public GameObject game;
	public float healt=50f;
	//private AImonster dead;
	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		//anim=GetComponent<Animator>();
	}
	
	public void TakeDamage (float amount){
		
		healt-=amount;
		if(healt<=0f){
			
			
			Die();
		}
		
	}
	
	void Die(){
		
		
		Debug.Log("DEAD");
		//dead.anim.Play("dead");
		//Destroy(game,2f);
		Destroy(gameObject);
	}
}
