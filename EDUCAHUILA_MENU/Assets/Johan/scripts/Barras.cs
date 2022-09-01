using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barras : MonoBehaviour
{
    // Las siguientes funciones solo son para propositos esteticos en el inspector de unity y no afectan la función del código en si

    // Space(espaciado en el inspector)
    // Header(titulo en el inspector)
    // Tooltip(texto al dejar el cursor sobre una variable en el inspector)

    // Para mostrar las variables hacer clic en el + al lado de "Variables del jugador"

    #region Variables de las barras

    [Space(10)]
    [Header("Variables de las barras")]

    [Tooltip("Las barra que indican al jugador su energia")]
    public Slider barra;

    #endregion

    public void BarraMax(int cantidad)
    {
        barra.maxValue = cantidad;
        barra.value = cantidad;
    }
    public void Barra(int cantidad)
    {
        barra.value = cantidad;
    }

}
