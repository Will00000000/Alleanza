using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bicicletario : MonoBehaviour
{
    public GameObject bicicleta1a, bicicleta1b;
    public GameObject jogador;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Bike1 ()
    {
        jogador.transform.position = bicicleta1b.transform.position;
    }
}
