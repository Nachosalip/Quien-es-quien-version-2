using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Llama a la función que imprime el mensaje
            PrintMessage("¡Interactuaste con el objeto!");
        }
    }

    // Función para imprimir un mensaje en la consola
    private void PrintMessage(string message)
    {
        Debug.Log(message);
    }
}