using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchweapon : MonoBehaviour
	{
		public GameObject pistol;
		public GameObject shootgun;
		public bool bor;
	
		// Start is called before the first frame update
		void Start()
		{
        
		}

		// Update is called once per frame
		void Update()
		{
			if(Input.GetKey(KeyCode.Alpha1)){
				
				
				pistol.SetActive(true);
				shootgun.SetActive(false);
	    	
			}
	    
			if(Input.GetKey(KeyCode.Alpha2)){
	    	
				if(bor==true){
					pistol.SetActive(false);
					shootgun.SetActive(true);
				}
			}
		}
	}