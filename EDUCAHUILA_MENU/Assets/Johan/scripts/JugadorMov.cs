using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class JugadorMov : MonoBehaviour
{
    // Las siguientes funciones solo son para propositos esteticos en el inspector de unity y no afectan la función del código en si

    // Space(espaciado en el inspector)
    // Header(titulo en el inspector)
    // Tooltip(texto al dejar el cursor sobre una variable en el inspector)

    // Para mostrar las variables hacer clic en el + al lado de "Variables del jugador"

    #region Variables del jugador

    [Space(10)]
    [Header("Variables de movimiento del jugador")]

    [Tooltip("El objeto donde se aplicara el codigo")]
    public GameObject jugador;
    [Tooltip("Animator con el que se acceden a las animaciones del jugador")]
    public Animator animaciones;
    [Tooltip("Joystick del jugador")]
    public Joystick stick;
    [Tooltip("Velocidad de movimiento del jugador")]
    public float velocidadMov;
    [Tooltip("Multiplicador para reducir la velocidad de movimiento del jugador")]
    public float MovRed;
    // vector usado para mover al jugador
    Vector2 Mov;

    [Space(10)]
    [Header("Variables de UI del jugador")]

    [Tooltip("Boton con el que el jugador interactua con un objeto")]
    public GameObject[] interactuar;
    [Tooltip("Ventana que aparece cuando el jugador interactua con un objeto")]
    public GameObject[] menu;
    [Tooltip("Script para modificar la barra de energia con las acciones del jugador")]
    public Barras contarEnergia;
    [Tooltip("Script para modificar la barra de progreso con las acciones del jugador")]
    public Barras contarProgreso;

    [Space(10)]
    [Header("Variables de interaccion del jugador")]

    [Tooltip("Objetos ocn lso que el jugador va a interactuar")]
    public GameObject[] objetosMision;

    // entero para coordinar el despligue de menus
    int indice;

    #endregion
    void Start()
    {
        jugador.GetComponent<Rigidbody2D>();

        foreach (GameObject boton in interactuar)
        {
            boton.SetActive(false);
        }

        foreach (GameObject ventana in menu)
        {
            ventana.SetActive(false);
        }

        foreach (GameObject objeto in objetosMision)
        {
            objeto.SetActive(true);
        }
    }
    void FixedUpdate()
    {
        Mover();
    }
    void Mover()
    {
        float x, y;
        Rigidbody2D rb = jugador.GetComponent<Rigidbody2D>();
        x = stick.Horizontal + Input.GetAxis("Horizontal");
        y = stick.Vertical + Input.GetAxis("Vertical");
        Mov = new Vector2(x, y);
        rb.MovePosition(rb.position + Mov * velocidadMov * Time.fixedDeltaTime);
    }
    public void Cerrar()
    {
        menu[indice].SetActive(false);
        objetosMision[indice].SetActive(false);
        Time.timeScale = 1;
        contarEnergia.barra.value -= 1;
        contarProgreso.barra.value += 1;

        if (contarProgreso.barra.value == contarProgreso.barra.maxValue)
        {
            print("siguiente nivel desbloqueado");
        }

        if (contarEnergia.barra.value == contarEnergia.barra.minValue)
        {
            print("ya no tienes energia para continuar");
            velocidadMov = 0;
        }
    }

    public void QuitarPausa()
    {
        menu[indice].SetActive(false);
        Time.timeScale = 1;
    }

    public void Interactuar(int caso)
    {
        switch (caso)
        {
            case 0:
                indice = 0;
                menu[indice].SetActive(true);
                Time.timeScale = 0;
                print("menu de planeta desplegado");
                break;
            case 1:
                indice = 1;
                menu[indice].SetActive(true);
                Time.timeScale = 0;
                print("menu de quimica desplegado");
                break;
            case 2:
                indice = 2;
                menu[indice].SetActive(true);
                Time.timeScale = 0;
                print("menu de prueba3 desplegado");
                break;
            case 3:
                indice = 3;
                menu[indice].SetActive(true);
                Time.timeScale = 0;
                print("menu de prueba4 desplegado");
                break;
            case 4:
                indice = 4;
                menu[indice].SetActive(true);
                Time.timeScale = 0;
                print("menu de prueba5 desplegado");
                break;
            case 5:
                indice = 5;
                menu[indice].SetActive(true);
                Time.timeScale = 0;
                print("menu de prueba6 desplegado");
                break;
            case 6:
                indice = 6;
                menu[indice].SetActive(true);
                Time.timeScale = 0;
                print("menu de prueba7 desplegado");
                break;
            case 7:
                indice = 7;
                menu[indice].SetActive(true);
                Time.timeScale = 0;
                print("menu de pausa desplegado");
                break;
        }
    }

    // Triggers

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider2D>().tag == "agua")
        {
            velocidadMov *= MovRed;
        }

        if (collision.GetComponent<Collider2D>().tag == "planeta")
        {
            indice = 0;
            interactuar[indice].SetActive(true);
        }

        if (collision.GetComponent<Collider2D>().tag == "quimica")
        {
            indice = 1;
            interactuar[indice].SetActive(true);
        }

        if (collision.GetComponent<Collider2D>().tag == "prueba3")
        {
            indice = 2;
            interactuar[indice].SetActive(true);
        }

        if (collision.GetComponent<Collider2D>().tag == "prueba4")
        {
            indice = 3;
            interactuar[indice].SetActive(true);
        }

        if (collision.GetComponent<Collider2D>().tag == "prueba5")
        {
            indice = 4;
            interactuar[indice].SetActive(true);
        }

        if (collision.GetComponent<Collider2D>().tag == "prueba6")
        {
            indice = 5;
            interactuar[indice].SetActive(true);
        }

        if (collision.GetComponent<Collider2D>().tag == "prueba7")
        {
            indice = 6;
            interactuar[indice].SetActive(true);
        }

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider2D>().tag == "agua")
        {
            velocidadMov /= MovRed;
        }

        if (collision.GetComponent<Collider2D>().tag == "planeta")
        {
            indice = 0;
            interactuar[indice].SetActive(false);
        }

        if (collision.GetComponent<Collider2D>().tag == "quimica")
        {
            indice = 1;
            interactuar[indice].SetActive(false);
        }

        if (collision.GetComponent<Collider2D>().tag == "prueba3")
        {
            indice = 2;
            interactuar[indice].SetActive(false);
        }

        if (collision.GetComponent<Collider2D>().tag == "prueba4")
        {
            indice = 3;
            interactuar[indice].SetActive(false);
        }

        if (collision.GetComponent<Collider2D>().tag == "prueba5")
        {
            indice = 4;
            interactuar[indice].SetActive(false);
        }

        if (collision.GetComponent<Collider2D>().tag == "prueba6")
        {
            indice = 5;
            interactuar[indice].SetActive(false);
        }

        if (collision.GetComponent<Collider2D>().tag == "prueba7")
        {
            indice = 6;
            interactuar[indice].SetActive(false);
        }
    }
}
