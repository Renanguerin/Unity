using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class volumegame : MonoBehaviour {
	public Slider slmenu;
	public AudioSource msk;
	// Use this for initialization
	void Start () {
		slmenu.value = AudioListener.volume;
	}
	
	// Update is called once per frame
	void Update () {
		msk.volume = slmenu.value;
		AudioListener.volume = msk.volume;
	}
}
