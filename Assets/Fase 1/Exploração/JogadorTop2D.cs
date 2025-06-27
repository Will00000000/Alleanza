using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class JogadorTop2D : MonoBehaviour
{
    Rigidbody2D rig;
    Vector2 mover;

    public float velocidade;

    void Start()
    {
        rig = GetComponent <Rigidbody2D>();
    }

    void Update()
    {
        rig.velocity = mover * velocidade;
    }

    public void OnMover (InputAction.CallbackContext context)
    {
        mover = context.ReadValue <Vector2>();
    }
}
