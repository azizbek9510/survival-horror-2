using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AImonster : MonoBehaviour
{
	public NavMeshAgent enemy;
	public Transform player;
	public Animator anim;
	public bool dead;
	
    // Start is called before the first frame update
    void Start()
	{
	
		anim=GetComponent<Animator>();
		enemy=GetComponent<NavMeshAgent>();
		dead=true;
    }

    // Update is called once per frame
    void Update()
	{
		
		
			//anim.SetBool("move",true);
		
			enemy.SetDestination(player.position);
		
		
		
			
				
		//anim.SetBool("dead",true);
			//dead=false;
			
			//anim.SetBool("dead",false);}
	}
			
    
	public 	void kill(){
		Debug.Log("DEAD");
		
		enemy.Stop();
	}
    
    
}
