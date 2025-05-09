using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    RectTransform rt;
    CanvasGroup colisaoCanvas;

    private void Awake ()
    {
        rt = GetComponent <RectTransform> ();
    }

    public void OnBeginDrag (PointerEventData eventData)
    {
        colisaoCanvas.blocksRaycasts = false;
    }

    public void OnDrag (PointerEventData eventData)
    {
        rt.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag (PointerEventData eventData)
    {
        colisaoCanvas.blocksRaycasts = true;
    }

    public void OnPointerDown (PointerEventData eventData)
    {
        Debug.Log ("Pointer");
    }
}
