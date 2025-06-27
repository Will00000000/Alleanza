using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class GerenciadorCursor : MonoBehaviour
{
    [SerializeField] private Texture2D cursorTextureAberta, cursorTextureFechada;

    private Vector2 cursorHotspot;

    void Start()
    {
        cursorHotspot = new Vector2(0, 0);
        Cursor.SetCursor(cursorTextureAberta, cursorHotspot, CursorMode.Auto);
    }

    public void OnCursor(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            Cursor.SetCursor(cursorTextureFechada, cursorHotspot, CursorMode.Auto);
        }

        if (context.phase == InputActionPhase.Canceled)
        {
            Cursor.SetCursor (cursorTextureAberta, cursorHotspot, CursorMode.Auto);
        }
    }
}