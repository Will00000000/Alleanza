using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorCursor : MonoBehaviour
{
    [SerializeField] private Texture2D cursorTextureAberta, cursorTextureFechada;

    private Vector2 cursorHotspot;

    // Start is called before the first frame update
    void Start()
    {
        cursorHotspot = new Vector2 (0, 0);
        Cursor.SetCursor (cursorTextureAberta, cursorHotspot, CursorMode.Auto);
    }

    void Update ()
    {
        if (Input.GetMouseButtonDown (0))
        {
            Cursor.SetCursor (cursorTextureFechada, cursorHotspot, CursorMode.Auto);
        }
    }
}
