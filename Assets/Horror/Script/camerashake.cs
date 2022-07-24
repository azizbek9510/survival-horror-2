using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerashake : MonoBehaviour
{
	public Animator anim;
	public bool run;
	private PlayerMovment move;
    // Start is called before the first frame update
    void Start()
	{ 
		
		anim=GetComponent<Animator>();
		run=false;
    }

    // Update is called once per frame
    void Update()
	{
		
		
		
		if(run==true){
			
			anim.SetBool("run",true);
		}
		if(run==false){
			
			anim.SetBool("run",false);
		}
		
		
    }
}
