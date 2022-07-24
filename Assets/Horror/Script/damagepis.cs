using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class damagepis : MonoBehaviour
{
	public float damage= 10f;
	public float range =100f;
	
	public Camera cam;
	public ParticleSystem gun;
	public AudioSource sound;
   
	//o'qdori kodi
	//public int Magazinammo=12;
	private magazinpistolet ammo;
	public int maxammo=6;
	public int bullet;
	public int qoldiq;
	public int raqam;
	public bool tugadi;
	public Text text;
	
	public float Reloadtime =  2f;
	public bool  isReloading;
	
	public Animator anim;
	private switchweapon change;
	
	//public GameObject crosshair;
	
	public bool canshoot;
	private BACKMENU back;
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		anim.keepAnimatorControllerStateOnDisable=true;
		ammo=FindObjectOfType<magazinpistolet>();
		anim=GetComponent<Animator>();
		anim.SetBool("changeweapon",true);
		canshoot=true;
		bullet=maxammo;
		change=FindObjectOfType<switchweapon>();
	}
    // Update is called once per frame
    void Update()
	{
		Invoke("retardanimation",0.1f);
		
		
		
		
		
		
		
		
		/*if(bullet==0&&Input.GetButtonDown("Fire1")&&!isReloading){
			Debug.Log("O'Q TAMOM");
			return;
		}*/
		
		
		
		
		
		
			
		if(bullet==0&&Input.GetButtonDown("Fire1")&&!isReloading){
			
			anim.SetBool("shoot",false);
			anim.SetBool("reload",true);
			
		StartCoroutine(Reload());
			
		
		}
		
		if(bullet>0){
				
			anim.SetBool("shoot",false);
			
		
		
					
					back=FindObjectOfType<BACKMENU>();
				if(back.menu==false){
			
					if(Input.GetButtonDown("Fire1")&&canshoot){
	    	
						anim.SetBool("changeweapon",false);
				 Shoot();
	    	
					}
				
			}
		}else{
			
				anim.SetBool("shoot",false);
		}
		
		
			
		if(Input.GetKeyDown(KeyCode.R)&&ammo.Magazinammo>0&&canshoot){
			canshoot=false;
			anim.SetBool("reload",true);
			
			Invoke("reload",2f);
			
			
		
		}
		if(Input.GetKeyDown(KeyCode.R)&&bullet==maxammo){
			
			anim.SetBool("reload",false);
			
	
			
			
		
		}
		if(ammo.Magazinammo!=null)
		text.text=bullet+"/"+ammo.Magazinammo;
		
		if(bullet==0 && ammo.Magazinammo==0){
			
			anim.SetBool("reload",false);
			//anim.SetBool("shoot",false);
			return;
		}
		
		if(isReloading)
			return;
		
		
		
		
		
		
			
		
		}
	void retardanimation(){
		
		anim.SetBool("changeweapon",false);
	}
	
	
	void reload(){
		
		if(ammo.Magazinammo<maxammo){
				
				qoldiq=maxammo-bullet;
				ammo.Magazinammo-=qoldiq;
			    raqam=ammo.Magazinammo+bullet;
				
				
				if(raqam<maxammo){
				
					raqam=maxammo+ammo.Magazinammo;
					if(raqam<maxammo){
						bullet+=ammo.Magazinammo;
					}else{
						
						
						Debug.Log("error");
					}
					
				}
				
				if(ammo.Magazinammo<=0){
					
					ammo.Magazinammo=0;
				}
			
				
				bullet=bullet+qoldiq;
				Debug.Log(qoldiq);
					
			}else{
						
				qoldiq=maxammo;
				qoldiq-=bullet;
				ammo.Magazinammo-=qoldiq;
				bullet=maxammo;
				//Debug.Log(Magazinammo);
						
			}
		
		canshoot=true;
		anim.SetBool("reload",false);
		
	}
		
	
		
		
    
	 void Shoot(){
		gun.Play();
		sound.Play();
		canshoot=false;
		anim.SetBool("shoot",true);
		bullet--;
		 StartCoroutine(pistol());
		RaycastHit hit;
		if(Physics.Raycast(cam.transform.position,cam.transform.forward,out hit,range)){
			
			
			Debug.Log(hit.transform);
			
			Target target	= hit.transform.GetComponent<Target>();
			
			if(target!=null){
				target.TakeDamage(damage);
				
				}
				
				
		}
	}
	
	
	IEnumerator Reload(){
		
		isReloading = true;
		
		
		
		yield return new WaitForSeconds(Reloadtime);
		
		
		
		if(ammo.Magazinammo>=maxammo){
			
			bullet=maxammo;	
			ammo.Magazinammo-=maxammo;
			//change.shootgunweapon=true;
			//change.shootgunweapon=true;
		}
		else{
			bullet=ammo.Magazinammo;
			ammo.Magazinammo=0;
			
		}
		
		anim.SetBool("reload",false);
		
		isReloading=false;
	}
	
	IEnumerator pistol(){
		
		yield return new WaitForSeconds(0.1f);
		canshoot=true;
		anim.SetBool("shoot",false);
	}
	// OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider.
	// OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider.
	
	
	
	
	
	}
	
	

