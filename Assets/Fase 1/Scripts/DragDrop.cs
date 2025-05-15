using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rt;

    private void Awake ()
    {
        rt = GetComponent <RectTransform> ();
    }

    public void OnBeginDrag (PointerEventData eventData)
    {
        Debug.Log ("Começou a arrastar");
    }

    public void OnDrag (PointerEventData eventData)
    {
        Debug.Log ("Está arrastando");
        rt.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag (PointerEventData eventData)
    {
        Debug.Log ("Terminou de arrastar");

    }
    public void OnPointerDown (PointerEventData eventData)
    {
        Debug.Log ("Clicou no item");
    }
}
