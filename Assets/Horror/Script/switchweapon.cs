using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchweapon : MonoBehaviour
	{
		public GameObject pistol;
		public GameObject shootgun;
		public GameObject aks;
		public GameObject crossshair;
		private WEAPONOn add;
		private WEAPONaks add2;
		
		[HideInInspector]
		
		
		private damagepis picselect;
		private shootgunshoot anim;
		private AKSshoot anim2;
		public bool pistolet;
		public bool shootgunweapon;
		public bool aksweapon;
		public int weapon;
		// Start is called before the first frame update
		void Start()
		
		
		{   add=FindObjectOfType<WEAPONOn>();
			add2=FindObjectOfType<WEAPONaks>();
			//pistolet =true;
			shootgunweapon=false;
			picselect = GetComponent<damagepis>();
			anim=GetComponent<shootgunshoot>();
			anim2=FindObjectOfType<AKSshoot>();
			aksweapon=false;
			if(picselect!=null)
				picselect.anim.keepAnimatorControllerStateOnDisable=true;
			if(anim!=null)
				anim.anim.keepAnimatorControllerStateOnDisable=true;
			if(anim2!=null)
			anim2.anim.keepAnimatorControllerStateOnDisable=true;
		}

		// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
		
		// Update is called once per frame
		void Update()
		{
			if(Input.GetKey(KeyCode.Alpha1)&&pistolet==true){
				if(anim!=null)
					anim.anim.SetBool("zoom2",false);
				if(anim!=null)
					anim.anim.SetBool("noshoot",true);
				if(anim!=null)
				    anim.anim.SetBool("reload2",false);
				if(anim2!=null)
					anim2.anim.SetBool("akszoom",false);
				if(anim2!=null)
				    anim2.anim.SetBool("aksreload",false);
				weapon=1;
				if(anim!=null)
					anim.isReloading=false;
				if(anim2!=null)
				   anim2.isReloading=false;
				pistolet =false;
				shootgunweapon=true;
				aksweapon=true;
				//if(crossshair!=null)
				crossshair.SetActive(true);
			}
			if(Input.GetKey(KeyCode.Alpha2)&&shootgunweapon==true && add.weaponadd==true){
				if(picselect!=null)
					picselect.anim.SetBool("zoom",false);
				if(picselect!=null)
				    picselect.anim.SetBool("reload",false);
				if(anim2!=null)
					anim2.anim.SetBool("akszoom",false);
				if(anim2!=null)
				anim2.anim.SetBool("aksreload",false);
				weapon=2;
				if(anim2!=null)
					anim2.isReloading=false;
				if(picselect!=null)
				picselect.isReloading=false;
				pistolet =true;
				shootgunweapon=false;
				aksweapon=true;
				//if(crossshair!=null)
				crossshair.SetActive(true);
				
			}
			if(Input.GetKey(KeyCode.Alpha3)&&aksweapon==true&&add2.weaponadd==true){
				if(picselect!=null)
					picselect.anim.SetBool("zoom",false);
				if(picselect!=null)
				picselect.anim.SetBool("reload",false);
				if(anim!=null)
					anim.anim.SetBool("noshoot",true);
				if(anim!=null)
				    anim.anim.SetBool("reload2",false);
				if(anim!=null)
					anim.anim.SetBool("zoom2",false);
				weapon=3;
				if(picselect!=null)
					picselect.isReloading=false;
				if(anim!=null)
					anim.isReloading=false;
				
				pistolet =true;
				shootgunweapon=true;
				aksweapon=false;
				//if(crossshair!=null)
				crossshair.SetActive(true);
			}
			
			
			switch (weapon) {
			case 1:
			
				Invoke("change1",0.6f); 
					    
    
    break;
			case 2:
			
				
				
				Invoke("change2",0.5f); 	
				
    
    break;
			case 3:
			
			
				Invoke("change3",0.6f); 
  
    break;
		
			}	
			
					
		}
		
		
		void change1(){
			
			
				   weapon=0;
			        pistol.SetActive(true);
					shootgun.SetActive(false);
					aks.SetActive(false);
			
			picselect=FindObjectOfType<damagepis>();
					if(picselect!=null)
						picselect.anim.SetBool("changeweapon",true);
					Invoke("retard",0.1f);
				
				
			
		}
		
		void change2(){
		
			      weapon=0;
				anim=FindObjectOfType<shootgunshoot>();
					if(anim!=null)
						anim.anim.SetBool("changeweapon2",true);			
				pistol.SetActive(false);
					shootgun.SetActive(true);
					aks.SetActive(false);
							
				Invoke("retards", 0.1f);
					
					
		
		}
		
		void change3(){
			
					weapon=0;
				anim2=FindObjectOfType<AKSshoot>();
				if(anim2!=null)
					anim2.anim.SetBool("changeweapon",true);				
				pistol.SetActive(false);
				aks.SetActive(true);
				shootgun.SetActive(false);					
				Invoke("retardaks", 0.1f);
		
			
		
		
			
		}
		
		
		void retard(){
			
			picselect.anim.SetBool("changeweapon",false);
		}
		
		void retards(){
			if(anim!=null)
			anim.anim.SetBool("changeweapon2",false);
		}
		
		void retardaks(){
			anim2.anim.SetBool("changeweapon",false);
			
		}
	}