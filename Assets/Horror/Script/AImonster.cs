using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AImonster : MonoBehaviour
{
	public NavMeshAgent enemy;
	public Transform player;
	public Animator anim;

	
    // Start is called before the first frame update
    void Start()
	{
		anim=GetComponent<Animator>();
	    enemy=GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
	{
		anim.SetBool("move",true);
		
		enemy.SetDestination(player.position);
	    
		
    }
}
