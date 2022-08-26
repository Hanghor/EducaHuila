using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Educa_Move1 : MonoBehaviour
{
    public GameObject educaMarcas;
    public GameObject educa;
    public bool abierto;
    

    // Start is called before the first frame update
    void Start()
    {
        abierto = false;
        educaMarcas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Movimiento()
    {
        if (abierto)
        {
            educa.transform.position = new Vector2(1800, 1100);
            educaMarcas.SetActive(false);
            abierto = false;
        }
        else
        {
            educa.transform.position = new Vector2(1340, 1100);
            educaMarcas.SetActive(true);
            abierto = true;
        }
    }
}
