using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public RectTransform rt;
    CanvasGroup colide;

    private void Awake ()
    {
        rt = GetComponent <RectTransform> (); //atribui a posição da peça para a variável "rt"
        colide = GetComponent <CanvasGroup> ();
    }

    public void OnBeginDrag (PointerEventData eventData)
    {
        Debug.Log ("Começou a arrastar");
    }

    public void OnDrag (PointerEventData eventData)
    {
        Debug.Log ("Está arrastando");
        rt.anchoredPosition += eventData.delta;
        colide.blocksRaycasts = false;
    }

    public void OnEndDrag (PointerEventData eventData)
    {
        Debug.Log ("Parou de arrastar");
        colide.blocksRaycasts = true;
    }

    public void OnPointerDown (PointerEventData eventData)
    {
        Debug.Log ("Clicou");
    }
}