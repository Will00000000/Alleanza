using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NascerFrag : MonoBehaviour
{
    public GameObject prefabFrag;
    public GameObject instanciaFrag;

    // Start is called before the first frame update
    void Start()
    {
        instanciaFrag = Instantiate (prefabFrag, new Vector3 (62f,30f,0f), Quaternion.identity);
        instanciaFrag = Instantiate (prefabFrag, new Vector3 (49f,26f,0f), Quaternion.identity);
        instanciaFrag = Instantiate (prefabFrag, new Vector3 (59f,25f,0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}