using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reborngame : MonoBehaviour
{
    //privacidade 	tipo         	 nome
    private Rigidbody2D playerRb;
    public float velocidade;
    private SpriteRenderer playerSprite;
    public bool flipX;


    // Use this for initialization
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            velocidade = velocidade * -1;
            flipX = !flipX;
            playerSprite.flipX = flipX;

        }
        playerRb.velocity = new Vector2(velocidade, playerRb.velocity.y);
    }





    void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.tag == "espinho")
        {
            if (pontuacao.pontos > PlayerPrefs.GetInt("record"))
            {
                PlayerPrefs.SetInt("record", pontuacao.pontos);
            }
            PlayerPrefs.SetInt("ptsat", pontuacao.pontos);
            SceneManager.LoadScene("FimReborn");
        }
    }
}