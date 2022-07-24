using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerazoom : MonoBehaviour
{
	
	public Camera cam;
	
	private switchweapon change;
	public bool zoomno;
	
    // Start is called before the first frame update
    void Start()
	{
		zoomno=true;
	     cam=GetComponent<Camera>();
	     
    }

    // Update is called once per frame
    void Update()
	{ 
		
		//float zoom=speed*Time.deltaTime;
		change=FindObjectOfType<switchweapon>();
    	
    	
    	
		if(Input.GetButtonDown("Fire2")){
	    	
	    	if(zoomno==true)
		    	zoomno=false;
			if(cam.fieldOfView>=75){
				cam.fieldOfView=45f/**Time.deltaTime*/;
	    	}else{
	    		
	    		cam.fieldOfView=45f;
	    	}
		    Debug.Log("CAMERA YAQIN");
		     
		    
		}else{
			cam.fieldOfView=75f;
			zoomno=true;
			/*if(cam.fieldOfView==45){
		    	Debug.Log("CAMERA chiqdi");
				cam.fieldOfView=75f;
		    	
		    	  }else{
	    	
			}*/
		    
			
		}
	    
	    
	    
	        
	 
	
	
    
 }
}
