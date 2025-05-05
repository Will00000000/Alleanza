using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportes : MonoBehaviour
{
    public Transform jogador, outroLadoAbismo;

    public Transform minigameFragmentos;

    void OnCollisionEnter2D (Collision2D col)
    {
        if (gameObject.tag == "ponte" && col.gameObject.tag == "jogador")
        {
            jogador.transform.position = new Vector3 (outroLadoAbismo.position.x, outroLadoAbismo.position.y, transform.position.z);
        }

        if (gameObject.tag == "minigameFrag" && col.gameObject.tag == "jogador")
        {
            jogador.transform.position = new Vector3 (minigameFragmentos.position.x, minigameFragmentos.position.y, transform.position.z);
        }
    }
}
