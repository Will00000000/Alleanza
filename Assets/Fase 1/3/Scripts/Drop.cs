using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{
    public RectTransform posicaoSombra; //acessar a posição da sombra que recebeu o drop
    bool correta; //variável que diz se a peça conectada é a correta ou não

    DragDrop arrastar; //pega o script de arrastar peças

    void Start ()
    {
        posicaoSombra = GetComponent <RectTransform> (); //atribui a posição da sombra à variável "posicaoSombra"
    }

    public void OnDrop (PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            Debug.Log ("Dropou1");

            eventData.pointerDrag.GetComponent <RectTransform> ().anchoredPosition = GetComponent <RectTransform> ().anchoredPosition;

            if (eventData.pointerDrag.gameObject.tag == gameObject.tag) //se a posição da sombra for igual a posição da peça que está sendo arrastada (e) a tag da sombra for igual a tag do objeto que foi conectado
            {
                correta = true; //a peça está correta
                Debug.Log ("Correta");
            }
            else
            {
                correta = false; //a peça está incorreta
                Debug.Log ("Incorreta");
            }
        }
    }
}