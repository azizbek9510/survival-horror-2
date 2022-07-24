using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoom : MonoBehaviour
{
	public Animator anim;
	
	public GameObject crosshair;
	private damagepis shoot;
	public bool press;
    // Start is called before the first frame update
	void Start()
    
	{   anim.keepAnimatorControllerStateOnDisable=true;
		press= true;
	    anim= GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
	{
		
		
		
		if(Input.GetButtonDown("Fire2")){
			
			if(press==true){
				press=false;
			crosshair.SetActive(false);
			anim.SetBool("zoom",true);
			
			
		}else{
			press=true;
			crosshair.SetActive(true);
			anim.SetBool("zoom",false);
		
		}
		}
		shoot=FindObjectOfType<damagepis>();
		if(shoot!=null)
			if(shoot.bullet>0){
				
				if(Input.GetButtonDown("Fire1")){
				
			 anim.SetBool("ZOOM SHOOT",true);
				
					Invoke("restart", 0.1f);
				}	
				
			}	
				
	}			
			
	
	/*void retard(){
		
		anim.SetBool("zoom",false);
	}*/

	
    
    
	 void restart(){
		
		  anim.SetBool("ZOOM SHOOT",false);
		     
	}


}