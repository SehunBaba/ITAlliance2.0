﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level01_Load : MonoBehaviour {

	// Use this for initialization
	public IEnumerator Start () 
	{
		yield return new WaitForSeconds (3);
		SceneManager.LoadScene (1); //Each Scene is assigned a number, in the build settings, this loads number 1 which is the the first level
	}

}