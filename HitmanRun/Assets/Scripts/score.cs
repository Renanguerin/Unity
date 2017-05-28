using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
	public  Text 	ptsattTXT;
	// Use this for initialization
	void Start () {
		ptsattTXT.text = PlayerPrefs.GetInt ("ptsat").ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
