using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fragmentos : MonoBehaviour
{
    public GameObject jogadorPai;
    public float velocidade;

    //public GameObject prefabFrag;
    //GameObject instanciaFrag;

    void Start ()
    {
        jogadorPai = GameObject.FindWithTag ("jogador");
        //instanciaFrag = Instantiate (prefabFrag, new Vector3 (62f,30f,0f), Quaternion.identity);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "jogador")
        {
            transform.SetParent (jogadorPai.transform);
        }
        if (col.gameObject.tag == "soltarFrag")
        {
            transform.SetParent (null);
        }
    }
}