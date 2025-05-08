using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    RectTransform rt;

    private void Awake ()
    {
        rt = GetComponent <RectTransform> ();
    }

    public void OnBeginDrag (PointerEventData eventData)
    {
        Debug.Log ("OnBegin");
    }

    public void OnDrag (PointerEventData eventData)
    {
        rt.anchoredPosition += eventData.delta;
        Debug.Log ("OnDrag");
    }

    public void OnEndDrag (PointerEventData eventData)
    {
        //throw new System.NotImplementedException ();
        Debug.Log ("Saiu");
    }

    public void OnPointerDown (PointerEventData eventData)
    {
        //throw new System.NotImplementedException ();
        Debug.Log ("Pointer");
    }
}
