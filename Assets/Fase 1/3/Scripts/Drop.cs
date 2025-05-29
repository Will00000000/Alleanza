using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{
    public RectTransform posicaoSombra;

    public void OnDrop (PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            Debug.Log ("Dropou1");

            eventData.pointerDrag.GetComponent <RectTransform> ().anchoredPosition = GetComponent <RectTransform> ().anchoredPosition;
        }
    }

    void Verificar ()
    {
        posicaoSombra = GetComponent <RectTransform> ();
    }
}