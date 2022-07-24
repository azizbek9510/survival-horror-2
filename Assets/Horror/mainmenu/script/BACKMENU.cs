using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BACKMENU : MonoBehaviour
{
	public GameObject main_menu;
	public GameObject ammo;
	public bool menu;
	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		//menu=false;
	}
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
	    if(Input.GetKeyDown(KeyCode.Escape)){
	    	
	    	if(menu==false){
	    		
	    		Time.timeScale=0f;
	    		Cursor.lockState = CursorLockMode.Confined;
	    		menu=true;
	    		main_menu.SetActive(true);
	    		ammo.SetActive(false);
		    	Cursor.visible = true;
	    	}else{
	    		Time.timeScale=1f;
	    		Cursor.visible = true;
	    		menu=false;
	    		main_menu.SetActive(false);
	    		ammo.SetActive(true);
		    	Cursor.lockState = CursorLockMode.Locked;
	    	}
	    	
	    	
	    	
	    }
    }
}
