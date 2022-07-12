using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashOn : MonoBehaviour
{
	public GameObject fonar;
	public bool flash;
    // Start is called before the first frame update
    void Start()
    {
	    fonar.SetActive(false);
	    
    }

    // Update is called once per frame
	void Update()
    {
	    if(Input.GetKeyDown(KeyCode.F)){
	    	if(flash==false){
	    		flash=true;
	    		fonar.SetActive(true);
	    	}
	    	else{
	    		flash=false;
	    		fonar.SetActive(false);
	    	}
	    	
	    }
	    
    }
}
