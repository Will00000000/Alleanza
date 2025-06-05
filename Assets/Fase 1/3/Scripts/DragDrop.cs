using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    RectTransform rt;
    CanvasGroup colide;

    public Image sombra;

    void Start ()
    {
        
    }

    private void Awake ()
    {
        rt = GetComponent <RectTransform> (); //atribui a posição da peça para a variável "rt"
        colide = GetComponent <CanvasGroup> ();
    }

    public void OnBeginDrag (PointerEventData eventData)
    {

    }

    public void OnDrag (PointerEventData eventData)
    {
        rt.anchoredPosition += eventData.delta;
        colide.blocksRaycasts = false;
    }

    public void OnEndDrag (PointerEventData eventData)
    {
        colide.blocksRaycasts = true;
        
    }

    public void OnPointerDown (PointerEventData eventData)
    {

    }

    void VerificarCor ()
    {

    }
}