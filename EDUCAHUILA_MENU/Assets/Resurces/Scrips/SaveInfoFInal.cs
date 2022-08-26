using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveInfoFInal : MonoBehaviour
{
    private GameObject profecion;
    // Start is called before the first frame update
    void Start()
    {
        profecion = GameObject.FindGameObjectWithTag("profesion");
        profecion.GetComponent<profesion>().seleccion = PlayerPrefs.GetInt("profesion");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
