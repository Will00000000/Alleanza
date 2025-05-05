using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.InputSystem;

public class JogadorTop : MonoBehaviour
{
    Rigidbody2D rig;
    public int velocidade;
    public float velocidadeDash;
    public Vector2 destino, mover;
    public Vector3 destinoCam;
    public bool DashAtivado = false, CamSeguindo = true;
    private Camera visaoAtaque;

    [Header ("Animação")]
    public Animator anima;
    public SpriteRenderer sprd;

    //MINIGAME
    public Transform fragmentoFilho, jogadorParente;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent <Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (DashAtivado)
        {
            Dash ();
        }

        rig.velocity = mover * velocidade;
        
        if (rig.velocity.x > 0)
        {
            anima.SetFloat ("AndandoLados", 1);
            sprd.flipX = false;
        }
        if (rig.velocity.x == 0)
        {
            anima.SetFloat ("AndandoLados", 0);
        }
        if (rig.velocity.x < 0)
        {
            anima.SetFloat ("AndandoLados", -1);
            sprd.flipX = true;
        }
        if (rig.velocity.y > 0)
        {
            anima.SetFloat ("AndandoCimaBaixo", 1);
        }
        if (rig.velocity.y == 0)
        {
            anima.SetFloat ("AndandoCimaBaixo", 0);
        }
        if (rig.velocity.y < 0)
        {
            anima.SetFloat ("AndandoCimaBaixo", -1);
        }
    }

    public void OnMover (InputAction.CallbackContext context)
    {
        mover = context.ReadValue <Vector2> ();
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "area ataque")
        {
            DashAtivado = true;
            destino = col.transform.position;
            
            destinoCam = new Vector3 (col.transform.position.x, col.transform.position.y, -10);

            CamSeguindo = false;

            Debug.Log ("Entrou na área");
        }
    }

    void OnTriggerExit2D (Collider2D col)
    {
        if (col.gameObject.tag == "area ataque")
        {
            DashAtivado = false;

            CamSeguindo = true;
        }
    }

    private void Dash ()
    {
        if (Input.GetMouseButtonDown (0))
            {
                Debug.Log ("Ataque habilitado");
                destino = Camera.main.ScreenToWorldPoint (Input.mousePosition);
            }

        transform.position = Vector2.MoveTowards (transform.position, destino, velocidadeDash * Time.deltaTime);
    }
}
