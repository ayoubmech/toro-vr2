using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pale : MonoBehaviour
{
    private int contador;
    public TextMeshProUGUI textContador;
    
    void Start()
    {
        contador = 0; // Initialize contador to 0
        UpdateText(contador); // Update the text to reflect the initial contador value
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Caja"))
        {
            contador++;
            UpdateText(contador); // Update the text when the contador changes
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Caja"))
        {
            contador--;
            UpdateText(contador); // Update the text when the contador changes
        }
    }

    private void UpdateText(int cont)
    {
        if (textContador != null)
        {
            textContador.text = cont.ToString(); // Update the text to the current value of contador
        }
    }
}
