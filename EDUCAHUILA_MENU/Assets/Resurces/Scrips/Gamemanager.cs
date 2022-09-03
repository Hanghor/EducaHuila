using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public GameObject[] niveles;
    int[] rango = {0, 1, 2, 3, 4, 5, 6, 7};

    void Start()
    {
        niveles[rango[0]].SetActive(true);

        for(int i = 1; i < rango.Length; i++)
        {
            niveles[rango[i]].SetActive(false);
        }
    }

    public void MostrarNivel(int indice)
    {
        switch (indice)
        {
            case 1:
                //niveles[rango[1]].SetActive(true);
                SceneManager.LoadScene(1);
                print("nivel 1");
                break;
            case 2:
                //niveles[rango[2]].SetActive(true);
                print("nivel 3");
                break;
            case 3:
                //niveles[rango[3]].SetActive(true);
                print("nivel 4");
                break;
            case 4:
                //niveles[rango[4]].SetActive(true);
                print("nivel 5");
                break;
            case 5:
                //niveles[rango[5]].SetActive(true);
                print("nivel 6");
                break;
            case 6:
                //niveles[rango[6]].SetActive(true);
                print("nivel 7");
                break;
            case 7:
                //niveles[rango[7]].SetActive(true);
                print("nivel 8");
                break;
            case 8:
                print("nivel 8");
                break;
        }
    }
}
