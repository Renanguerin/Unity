using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cena2vol : MonoBehaviour {
	public AudioSource msk1;
	// Use this for initialization
	void Start () {
		msk1.volume = AudioListener.volume;
	}
	
	// Update is called once per frame
	void Update () {
		
	}



}
