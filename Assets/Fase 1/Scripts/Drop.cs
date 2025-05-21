using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{
    //string nomeTag;
    
    public void OnDrop (PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.gameObject.tag.Equals(gameObject.tag))
            {
                eventData.pointerDrag.GetComponent <RectTransform> ().anchoredPosition = GetComponent <RectTransform> ().anchoredPosition;
            }
        }
    }

    /*void Start ()
    {
        nomeTag = gameObject.tag;
    }*/
}