using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoVermelho : MonoBehaviour
{
    public GameObject alvo;
    public float velocidade;

    // Start is called before the first frame update
    void Start()
    {
        alvo = GameObject.FindWithTag ("jogador2d");
    }

    // Update is called once per frame
    void Update()
    {
        Seguir ();
    }

    void Seguir ()
    {
        transform.position = Vector2.MoveTowards (transform.position, alvo.transform.position, velocidade * Time.deltaTime);
    }
}
