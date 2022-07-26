using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIENEMY : MonoBehaviour
{
	public NavMeshAgent AGENT;
	public Transform player;
	
    // Start is called before the first frame update
    void Start()
    {
	    AGENT=GetComponent<NavMeshAgent>();
	    player=GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
	    AGENT.SetDestination(player.position);
    }
}
