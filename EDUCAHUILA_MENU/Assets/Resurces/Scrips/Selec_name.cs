using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Selec_name : MonoBehaviour
{
    public InputField inputTextName;
    public InputField inputTextInst;
    public InputField inputTextGrado;
    public Text textoNombre;
    public Text textoInst;
    public Text textoGrado;
    public GameObject butEnviar;
    public GameObject nameT;
    public GameObject instT;
    public GameObject gradoT;
    public GameObject nameF;
    public GameObject instF;
    public GameObject gradoF;
    public bool imgName;
    public bool imgInst;
    public bool imgGrado;
    


    private void Start()
    {
        nameT.SetActive(false);
        instT.SetActive(false);
        gradoT.SetActive(false);
        nameF.SetActive(false);
        instF.SetActive(false);
        gradoF.SetActive(false);
        butEnviar.SetActive(false);
    }
    private void Update()
    {
        //Nombre
        if (textoNombre.text.Length < 4)
        {
            nameF.SetActive(true);
            nameT.SetActive(false);
            imgName = false;
            
        }
        if (textoNombre.text.Length >= 4)
        {
            nameF.SetActive(false);
            nameT.SetActive(true);
            imgName = true;
        }
        if (textoNombre.text.Length == 0)
        {
            nameF.SetActive(false);
            nameT.SetActive(false);
            imgName = false;
        }
        //institud
        if (textoInst.text.Length < 4)
        {
            instF.SetActive(true);
            instT.SetActive(false);
            imgInst = false;
        }
        if (textoInst.text.Length >= 4)
        {
            instF.SetActive(false);
            instT.SetActive(true);
            imgInst = true;
        }
        if (textoInst.text.Length > 25)
        {
            instF.SetActive(true);
            instT.SetActive(false);
            imgInst = false;
        }
        if (textoInst.text.Length == 0)
        {
            instF.SetActive(false);
            instT.SetActive(false);
            imgInst = false;
        }
        //Grado
        if (textoGrado.text.Length < 0)
        {
            gradoF.SetActive(true);
            gradoT.SetActive(false);
            imgGrado = false;
        }
        if (textoGrado.text.Length >= 2)
        {
            gradoF.SetActive(false);
            gradoT.SetActive(true);
            imgGrado = true;
        }
        if (textoGrado.text.Length > 2)
        {
            gradoF.SetActive(true);
            gradoT.SetActive(false);
            imgGrado = false;
        }
        if (textoGrado.text.Length == 0)
        {
            gradoF.SetActive(false);
            gradoT.SetActive(false);
            imgGrado = false;
        }
        if (imgName && imgGrado && imgInst)
        {
            butEnviar.SetActive(true);
        }
        if (imgName == false || imgGrado == false || imgInst == false)
        {
            butEnviar.SetActive(false);
        }
    }
    
    public void Enviar()
    {
        
        PlayerPrefs.SetString("nombre1", inputTextName.text);
        PlayerPrefs.SetString("inst1", inputTextInst.text);
        PlayerPrefs.SetString("grado1", inputTextGrado.text);
        SceneManager.LoadScene("Scen_02");
    }


}
