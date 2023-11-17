using UnityEngine;
using UnityEngine.UI;

public class DropdownID : MonoBehaviour
{
    public Dropdown dropdown;

    void Start()
    {
        // Verifica si el campo dropdown está asignado
        if (dropdown != null)
        {
            // Añade un listener para manejar cambios en la selección
            dropdown.onValueChanged.AddListener(delegate {
                DropdownValueChanged(dropdown);
            });
        }
        else
        {
            Debug.LogError("El campo dropdown no ha sido asignado en el Inspector.");
        }
    }

    // Manejador del evento de cambio en la selección
    void DropdownValueChanged(Dropdown dropdown)
    {
        int opcionSeleccionada = dropdown.value;

        // Verifica si hay opciones antes de intentar acceder a ellas
        if (dropdown.options != null && dropdown.options.Count > opcionSeleccionada)
        {
            Debug.Log("Opción seleccionada: " + dropdown.options[opcionSeleccionada].text);
        }
        else
        {
            Debug.LogError("Error al acceder a las opciones del dropdown.");
        }
    }
}