using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI : MonoBehaviour
{
    public bool Pestanas = false;
    public GameObject MenuPestanasBut;
    public Button MenuPestanas;
    public float time;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void AbrirCerrar()
    {
        MenuPestanas.transform.position -= new Vector3(0, 2, 0);
        
        StartCoroutine(Accion());
        //StopCoroutine(Accion());
        Debug.Log ("abierto");
    }
    IEnumerator Accion()
    {
        MenuPestanas.GetComponent<Button>();
        MenuPestanas.interactable = false;
        yield return new WaitForSeconds(time);
        MenuPestanas.transform.position += new Vector3(0, 2, 0);
        MenuPestanas.interactable = true;
    }
    
}
