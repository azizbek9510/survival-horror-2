﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn : MonoBehaviour
{   public GameObject main_menu;
	public GameObject about;
    // Start is called before the first frame update
	public void btn(){
		
		main_menu.SetActive(false);
		about.SetActive(true);
		
	}
}
