using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    RectTransform rt;
    CanvasGroup colisaoCanvas;

    private void Awake ()
    {
        rt = GetComponent <RectTransform> ();
        colisaoCanvas = GetComponent <CanvasGroup> ();
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
}
