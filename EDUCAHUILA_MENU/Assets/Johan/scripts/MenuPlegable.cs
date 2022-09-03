using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuPlegable : MonoBehaviour
{
    public GameObject MenuAbierto,MenuCerrado;

    void Start()
    {
        MenuCerrado.SetActive(false);
    }
    
    public void Abrir()
    {
        MenuAbierto.SetActive(false);
        MenuCerrado.SetActive(true);
        MenuCerrado.transform.position -= new Vector3(0, 2, 0);
    }

    public void Cerrar()
    {
        MenuAbierto.SetActive(true);
        MenuCerrado.SetActive(false);
        MenuCerrado.transform.position += new Vector3(0, 2, 0);
    }
}
