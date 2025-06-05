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

    public RectTransform sombra;

    //float larguraPeca, alturaPeca; //variáveis que recebem a largura e a altura da peça

    void Start ()
    {
        /*sombra = GetComponent <RectTransform> (); //acessar o RectTransform da sombra
        larguraPeca = sombra.rect.width; //atribui a largura da sombra para a largura da peça

        larguraPeca = rt.rect.width; //atribui a largura da imagem para a largura da peça

        rt.rect.width=larguraPeca;*/
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
}