using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadlevel : MonoBehaviour
{
	public string scene;
	
	
	public void load(){
		Debug.Log("LOAD LEVEL");
		SceneManager.LoadScene(scene);
		Time.timeScale=1f;
	}
    
}
