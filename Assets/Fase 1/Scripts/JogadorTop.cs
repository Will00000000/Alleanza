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
    Animator anima;
    public SpriteRenderer sprd;

    [Header("Minigame")]
    public Transform fragmentoFilho;
    public Transform jogadorParente;

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
    }

    public void OnMover(InputAction.CallbackContext context)
    {
        mover = context.ReadValue<Vector2>();
        Debug.Log(rig.velocity);

        anima.SetFloat("SideMove", Mathf.Abs (mover.x));
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
