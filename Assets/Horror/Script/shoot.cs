using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shoot : MonoBehaviour
{
	public float damage= 10f;
	public float range =100f;
	
	public Camera cam;
	public ParticleSystem gun;
	public AudioSource sound;
   
	//o'qdori kodi
	public int MAXammo=12;
	public int patron=6;
	public int bullet;
	public float time;
	public bool tugadi;
	//public Text text;
	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		if(bullet==-1)
		bullet=MAXammo;
	}
    // Update is called once per frame
    void Update()
	{
		
		
		
	    if(Input.GetButtonDown("Fire1")){
	    	
	    	Shoot();
	    	Ammo();
	    }
	    
		if(bullet<=0){
			
			Reloading();
			return;
		}
		//text.text=bullet.ToString();
		if(Input.GetKeyDown(KeyCode.R)){
			
			
		}
				
		
	}
	
			
    
	void Shoot(){
		gun.Play();
		sound.Play();
		
		bullet--;
		RaycastHit hit;
		if(Physics.Raycast(cam.transform.position,cam.transform.forward,out hit,range)){
			
			
			Debug.Log(hit.transform);
			
			Target target	= hit.transform.GetComponent<Target>();
			
			if(target!=null){
				target.TakeDamage(damage);
				}
				
				
		}
	}
	
	void Ammo(){
		
		//patron-=1;
		
	}
	void Reloading(){
		
		bullet=MAXammo; 
	}
	
}
