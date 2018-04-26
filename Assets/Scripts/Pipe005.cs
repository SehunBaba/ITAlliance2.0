﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe005 : MonoBehaviour {



	public AudioSource PipeSound;
	public GameObject FadeScreen;
	public GameObject MainCam;
	public GameObject SecondCam;
	public GameObject PipeEntry;
	public GameObject MainPlayer;


	IEnumerator OnTriggerEnter(Collider col)
	{
		PipeSound.Play();
		FadeScreen.SetActive(true);
		FadeScreen.GetComponent<Animator>().enabled = true;
		yield return new WaitForSeconds(0.495F);
		FadeScreen.GetComponent<Animator>().enabled = false;
		MainCam.SetActive(true);
		SecondCam.SetActive(false);
		MainPlayer.transform.position = new Vector3(82.0F, 1.228f, 0.309f);  //value differs
		PipeEntry.GetComponent<Animator>().enabled = true;
		FadeScreen.GetComponent<Animator>().enabled = true;
		yield return new WaitForSeconds(0.495F);
		FadeScreen.GetComponent<Animator>().enabled = false;
		yield return new WaitForSeconds(1);
		PipeEntry.GetComponent<Animator>().enabled = false;
		FadeScreen.SetActive(false);

}

}