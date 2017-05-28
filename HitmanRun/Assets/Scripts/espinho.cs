using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espinho : MonoBehaviour {
	private Rigidbody2D espinhoRb;
	private 	int 		atrito;	
	public 		Vector3 	posicao;
	public 		GameObject	espinhoPrefab;

	// Use this for initialization
	void Start () 
	{
		espinhoRb = GetComponent<Rigidbody2D> ();
		atritoRandom();
		posicao = transform.position;
	}
	
	// Update is called once per frame

	void atritoRandom()
	{
		atrito = Random.Range(4,7);
		if (pontuacao.pontos > 25) {
			 
			atrito = Random.Range (3,5);
		if (pontuacao.pontos > 50) {
				
				atrito = Random.Range (2,5);
		if (pontuacao.pontos > 75) {
				
				atrito=Random.Range(1,4);
		if (pontuacao.pontos > 100) {
				
				atrito = Random.Range (0, 4);
					} 
		if (pontuacao.pontos > 150) {
				
				atrito = Random.Range (0, 2);
					}
		if (pontuacao.pontos > 200) {
			
				atrito =Random.Range (-1,1);
							


					}
					
				
				} 	
			}
		}
		espinhoRb.drag = atrito;
	}
	void OnBecameInvisible(){
		pontuacao.pontos += 1; //pontuacao.pontos = pontuacao.pontos + 1 ;
		GetComponent<AudioSource> ().Play ();
		atritoRandom();
		transform.position = posicao;

	}

}
