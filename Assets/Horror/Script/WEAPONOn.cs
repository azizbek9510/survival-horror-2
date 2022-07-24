using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WEAPONOn : MonoBehaviour
{
	
	public GameObject qoldagi;
	public GameObject qoldagi2;
	public GameObject qoldagi3;
	private camerazoom zoom;
	private switchweapon change;
	private shootgunshoot anim;
	public bool weaponadd;
    // Start is called before the first frame update
    void Start()
	{
		weaponadd=false;
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
				anim=FindObjectOfType<shootgunshoot>();
				if(anim!=null)
				anim.anim.SetBool("changeweapon2",true);
				
				change=FindObjectOfType<switchweapon>();
				
				weaponadd=true;
				change.pistolet = true;
				change.shootgunweapon=false;
				change.aksweapon=true;
				qoldagi.SetActive(true);
				qoldagi2.SetActive(false);
				qoldagi3.SetActive(false);
				Invoke("retardanimation",0.1f);
				Destroy(gameObject, 0.2f);
			}
		}
	}
	
	void retardanimation(){
		if(anim!=null)
			anim.anim.SetBool("changeweapon2",false);
		
	}
	
}
