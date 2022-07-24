using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WEAPONaks : MonoBehaviour
{
	
	public GameObject qoldagi;
	public GameObject qoldagi2;
	public GameObject qoldagi3;
	private camerazoom zoom;
	private switchweapon change;
	private AKSshoot anim2;
	public bool weaponadd;
    // Start is called before the first frame update
    void Start()
	{
		
	    qoldagi.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
	    
        
    }
    
	// OnTriggerStay is called once per frame for every Collider other that is touching the trigger.
	protected void OnTriggerStay(Collider other)
	{
		if(other.gameObject.tag=="Player"){
			if(Input.GetKey(KeyCode.E)){
				anim2=FindObjectOfType<AKSshoot>();
				if(anim2!=null)
					anim2.anim.SetBool("changeweapon",true);
				change=FindObjectOfType<switchweapon>();
			
		
			
				weaponadd=true;
				change.pistolet = true;
				change.shootgunweapon=true;
				change.aksweapon=false;
				qoldagi.SetActive(true);
				qoldagi2.SetActive(false);
				qoldagi3.SetActive(false);
				Invoke("retardanimation",0.1f);
				Destroy(gameObject, 0.2f);
			}
		}
	}
	
	void retardanimation(){
		
		if(anim2!=null)
			anim2.anim.SetBool("changeweapon",false);
	}
	
}
