using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunçõesAutomáticas : MonoBehaviour
{
    public GameObject inimigo, instanciaInimigo;
    public GameObject localSurgimento;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Inimigo (); 
    }

    void Inimigo ()
    {
        if (Input.GetMouseButtonDown(1))
        {
            instanciaInimigo = Instantiate (inimigo, localSurgimento.transform.position, Quaternion.identity);
        }
    }
}
