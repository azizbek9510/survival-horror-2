using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomshot : MonoBehaviour
{
	public Animator anim;
	
	public GameObject crosshair;
	private shootgunshoot shoot;
	public bool press;
	private bool canshoot;
	
	
    // Start is called before the first frame update
	void Start()
    
    
	{  
		anim.keepAnimatorControllerStateOnDisable=true;
		press= true;
		canshoot=true;
	    anim= GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
	{
		
		
		if(Input.GetButtonDown("Fire2")){
	    	
			if(press==true){
				press=false;
			crosshair.SetActive(false);
			anim.SetBool("zoom2",true);
			anim.SetBool("changeweapon2",false);
	    
		}else{
			press=true;
			crosshair.SetActive(true);
			anim.SetBool("zoom2",false);
		}
		
		}  
		if(Input.GetButtonDown("Fire1")&&shoot.bullet==1){
			
			anim.SetBool("SINGLE",true);
		}else{
			//anim.SetBool("SINGLE",false);
		}
		
		shoot=FindObjectOfType<shootgunshoot>();
		if(shoot!=null)
	
				Debug.Log("NATIJA "+shoot.bullet);
		if(Input.GetButtonDown("Fire1")&&canshoot&&shoot.bullet>0){
					anim.SetBool("zoomshoot2",true);
	    	        
					canshoot=false;
					StartCoroutine(shotgun());
				
					
				}
		
		
	    
		
	}

	

	IEnumerator shotgun(){
		
		yield return new WaitForSeconds(1f);
		canshoot=true;
		anim.SetBool("zoomshoot2",false);
	}


}