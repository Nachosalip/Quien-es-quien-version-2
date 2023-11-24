/*using UnityEngine;
using UnityEngine.UI;

public class BotonAdivinar : MonoBehaviour
{
    private JuegoQuienEsQuien juego;
    private bool modoAdivinar = false;

    void Start()
    {
        // Obtén una referencia al script del juego o crea una instancia de JuegoQuienEsQuien
        juego = FindObjectOfType<JuegoQuienEsQuien>();

        // Obtén el componente Button del botón
        Button boton = GetComponent<Button>();

        // Asocia la función CambiarModoAdivinar al evento onClick del botón
        boton.onClick.AddListener(CambiarModoAdivinar);
    }

    void CambiarModoAdivinar()
    {
        // Cambia el modo de adivinar al hacer clic en el botón
        modoAdivinar = !modoAdivinar;

        // Si el modo es verdadero, establece el juego en modo adivinar
        if (modoAdivinar)
        {
            juego.EntrarModoAdivinar();
        }
        else
        {
            juego.SalirModoAdivinar();
        }
    }
}
*/