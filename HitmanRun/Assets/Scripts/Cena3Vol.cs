using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cena3Vol : MonoBehaviour {
	public AudioSource msk;
	// Use this for initialization
	void Start () {
		msk.volume = AudioListener.volume;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
