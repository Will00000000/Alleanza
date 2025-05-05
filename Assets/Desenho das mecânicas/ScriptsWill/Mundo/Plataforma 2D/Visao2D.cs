using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visao2D : MonoBehaviour
{
    public Transform alvo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (alvo.position.x, alvo.position.y, transform.position.z);
    }
}
