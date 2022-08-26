using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Selec_Nickname : MonoBehaviour
{
    public InputField inputTextNickName;
    
    public Text textoNickNombre;
    
    public GameObject butEnviar;
    public GameObject hombre;
    public GameObject mujer;
    public GameObject jovenM;
    public GameObject mayorM;
    public GameObject jovenH;
    public GameObject mayorH;
    public GameObject menuH;
    public GameObject menuM;
    public GameObject nino;
    public GameObject joven;
    public GameObject ninoH;
    public GameObject jovenHo;

    public Image val;
    public int sexo;
    public int edad;



    // mujer = 0
    // hombre = 1

    private void Start()
    {
        val.color = Color.white;
        butEnviar.SetActive(true);
    }
    private void Update()
    {
        
        //Nombre
        if (textoNickNombre.text.Length >= 1 || textoNickNombre.text.Length <= 8)
        {
            val.color = Color.green;
            if (textoNickNombre.text.Length == 0)
            {
                val.color = Color.white;

            }
            if (textoNickNombre.text.Length > 8)
            {
                val.color = Color.red;

            }
        }
    }
    //sexo
    public void Hombre()
    {
        hombre.SetActive(true);
        mujer.SetActive(false);
        sexo = 1;
    }
    public void Mujer()
    {
        hombre.SetActive(false);
        mujer.SetActive(true);
        sexo = 0;
    }
    //MUJERES
    public void JovenM()
    {
        jovenM.SetActive(true);
        mayorM.SetActive(false);
        edad = 1;
    }
    public void MayorM()
    {
        jovenM.SetActive(false);
        mayorM.SetActive(true);
        edad = 0;
    }
    //HOMBRE

    public void JovenH()
    {
        jovenH.SetActive(true);
        mayorH.SetActive(false);
        edad = 1;
    }
    public void MayorH()
    {
        jovenH.SetActive(false);
        mayorH.SetActive(true);
        edad = 0;
    }
    public void Genero()
    {
        if (sexo == 1)
        {
            menuH.SetActive(true);
            menuM.SetActive(false);
        }
        if (sexo == 0)
        {
            menuH.SetActive(false);
            menuM.SetActive(true);
        }
    }
    
    public void Enviar()
    {
        if (val.color == Color.green)
        {
            PlayerPrefs.SetString("nicknombre1", inputTextNickName.text);
            PlayerPrefs.SetInt("sex", sexo);
            PlayerPrefs.SetInt("edad", edad);
            Debug.Log("saved" + sexo + inputTextNickName.text + edad);
        }
        else
        {
            Debug.Log("Incorrect");
        }    
    }
    public void EnviarGrado()
    {
        if (edad == 0 || edad == 1)
        {
            PlayerPrefs.SetInt("edad", edad);
            Debug.Log("saved" + edad);
        }
        else
        {
            Debug.Log("Incorrect");
        }
    }
    public void MenuGrado()
    {
        if (edad == 1)
        {
            nino.SetActive(true);
            joven.SetActive(false);
        }
        if (edad == 0)
        {
            nino.SetActive(false);
            joven.SetActive(true);
        }
    }
    public void MenuGradoH()
    {
        if (edad == 1)
        {
            ninoH.SetActive(true);
            jovenHo.SetActive(false);
        }
        if (edad == 0)
        {
            ninoH.SetActive(false);
            jovenHo.SetActive(true);
        }
    }



}
