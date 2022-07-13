using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WEAPONOn : MonoBehaviour
{
	
	public GameObject qoldagi;
	public GameObject qoldagi2;
	public GameObject CROSSSHAIR;
	public switchweapon change;
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
			
				change=FindObjectOfType<switchweapon>();
				change.bor=true;
			
				qoldagi.SetActive(true);
				qoldagi2.SetActive(false);
				CROSSSHAIR.SetActive(true);
				Destroy(gameObject, 0.1f);
			}
		}
	}
}
