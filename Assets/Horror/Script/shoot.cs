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
	public int Magazinammo=12;
	public int maxammo=6;
	public int bullet;
	public float time;
	public bool tugadi;
	public Text text;
	
	public float Reloadtime =  2f;
	public bool  isReloading;
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		bullet=maxammo;
	}
    // Update is called once per frame
    void Update()
	{
		
		if(bullet>=1){
			
		
		
	    if(Input.GetButtonDown("Fire1")){
	    	
	    	Shoot();
	    	
	    }
		}
	    
		
		text.text=bullet+"/"+Magazinammo;
		
		if(bullet==0 && Magazinammo==0){
			
			return;
		}
		
		if(isReloading)
			return;
		
		if(bullet==0 && !isReloading){
			StartCoroutine(Reload());
		}
		
		
		
		
		/*	if(Input.GetKeyDown(KeyCode.R)){
			
			
		}*/
				
		
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
	
	
	IEnumerator Reload(){
		
		isReloading = true;
		
		yield return new WaitForSeconds(Reloadtime);
		if(Magazinammo>=maxammo){
			
			bullet=maxammo;	
			Magazinammo-=maxammo;
		}
		else{
			bullet=Magazinammo;
			Magazinammo=0;
			
		}
		isReloading=false;
	}
	
}
