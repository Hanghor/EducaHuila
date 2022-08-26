using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class profesion : MonoBehaviour
{
    public GameObject op01;
    public GameObject op02;
    public GameObject op03;
    public GameObject op04;
    public GameObject op05;
    public GameObject op01pos;
    public GameObject op02pos;
    public GameObject op03pos;
    public GameObject op04pos;
    public GameObject op05pos;
    public int seleccion;
    public int seleccionpos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Deportista()
    {
        op01.SetActive(true);
        op02.SetActive(false);
        op03.SetActive(false);
        op04.SetActive(false);
        op05.SetActive(false);
        seleccion = 1;
    }
    public void Deportistapos()
    {
        op01pos.SetActive(true);
        op02pos.SetActive(false);
        op03pos.SetActive(false);
        op04pos.SetActive(false);
        op05pos.SetActive(false);
        seleccionpos = 1;
    }
    public void Agricultora()
    {
        op01.SetActive(false);
        op02.SetActive(true);
        op03.SetActive(false);
        op04.SetActive(false);
        op05.SetActive(false);
        seleccion = 2;
    }
    public void Agricultorapos()
    {
        op01pos.SetActive(false);
        op02pos.SetActive(true);
        op03pos.SetActive(false);
        op04pos.SetActive(false);
        op05pos.SetActive(false);
        seleccionpos = 2;
    }
    public void Arqueologo()
    {
        op01.SetActive(false);
        op02.SetActive(false);
        op03.SetActive(true);
        op04.SetActive(false);
        op05.SetActive(false);
        seleccion = 3;
    }
    public void Arqueologopos()
    {
        op01pos.SetActive(false);
        op02pos.SetActive(false);
        op03pos.SetActive(true);
        op04pos.SetActive(false);
        op05pos.SetActive(false);
        seleccionpos = 3;
    }
    public void Bailarina()
    {
        op01.SetActive(false);
        op02.SetActive(false);
        op03.SetActive(false);
        op04.SetActive(true);
        op05.SetActive(false);
        seleccion = 4;
    }
    public void Bailarinapos()
    {
        op01pos.SetActive(false);
        op02pos.SetActive(false);
        op03pos.SetActive(false);
        op04pos.SetActive(true);
        op05pos.SetActive(false);
        seleccionpos = 4;
    }
    public void Cientifica()
    {
        op01.SetActive(false);
        op02.SetActive(false);
        op03.SetActive(false);
        op04.SetActive(false);
        op05.SetActive(true);
        seleccion = 5;
    }
    public void Cientificapos()
    {
        op01pos.SetActive(false);
        op02pos.SetActive(false);
        op03pos.SetActive(false);
        op04pos.SetActive(false);
        op05pos.SetActive(true);
        seleccionpos = 5;
    }
    public void GuardadoProf()
    {
        PlayerPrefs.SetInt("profesion", seleccion);
        PlayerPrefs.SetInt("profesionpos", seleccionpos);
        Debug.Log("guardado" + " " + seleccion);

    }
}
