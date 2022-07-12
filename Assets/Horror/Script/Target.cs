using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
	public float healt=50f;
	
	public void TakeDamage (float amount){
		
		healt-=amount;
		if(healt<=0f){
			
			Die();
		}
		
	}
	
	void Die(){
		
		Destroy(gameObject);
		
	}
}
