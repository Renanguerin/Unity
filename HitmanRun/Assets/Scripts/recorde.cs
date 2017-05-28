using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class recorde : MonoBehaviour {
	public  Text 	recordeTXT;

	// Use this for initialization
	void Start () {
		recordeTXT.text = PlayerPrefs.GetInt ("record").ToString ();

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
