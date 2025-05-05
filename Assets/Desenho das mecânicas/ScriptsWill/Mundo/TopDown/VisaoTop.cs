using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisaoTop : MonoBehaviour
{
    public Transform alvo;
    public GameObject jogador;

    void Start ()
    {
        Camera.main.orthographicSize = 5;
    }

    void Update ()
    {
        Seguir ();
    }

    void Seguir ()
    {
        if (jogador.GetComponent <JogadorTop> ().CamSeguindo)
        {
            transform.position = new Vector3 (alvo.position.x, alvo.position.y, transform.position.z);
            Camera.main.orthographicSize = 5;
        }
        else
        {
            transform.position = jogador.GetComponent <JogadorTop> ().destinoCam;
            Camera.main.orthographicSize = 8;
        }
    }
}