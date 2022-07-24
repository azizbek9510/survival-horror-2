using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieSPAWN : MonoBehaviour
{
	public GameObject zombie;
	public Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
	{
		if(Input.GetKeyDown(KeyCode.T)){
			Instantiate(zombie,transform.position,Quaternion.identity);
		}
    }
}
