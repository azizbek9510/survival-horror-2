using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
	public float damage= 10f;
	public float range =100f;
	
	public Camera cam;
	public ParticleSystem gun;
	public AudioSource sound;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
	    if(Input.GetButtonDown("Fire1")){
	    	
	    	Shoot();
	    	
	    }
    }
    
    
	void Shoot(){
		gun.Play();
		sound.Play();
		RaycastHit hit;
		if(Physics.Raycast(cam.transform.position,cam.transform.forward,out hit,range)){
			
			
			Debug.Log(hit.transform);
			
			Target target	= hit.transform.GetComponent<Target>();
			if(target!=null){
				target.TakeDamage(damage);
			}
		}
	}
}
