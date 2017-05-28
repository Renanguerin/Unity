using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void jogar(){
		SceneManager.LoadScene ("Gameplay");
	
	}
	public void sair(){
		Application.Quit ();
	}
	public void retornar(){
		SceneManager.LoadScene ("Menu");
	}
	public void characterscene(){
		SceneManager.LoadScene ("Character");
	
	}
	public void byakuranjogar(){
		SceneManager.LoadScene ("Byakurangame");
	}
    public void rebornjogar()
    {
        SceneManager.LoadScene("Reborngame");
    }
	public void gokuderajogar(){
		SceneManager.LoadScene ("Gokuderagame");
	}
}
