using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Caja"))
        {
            SimuladorPrueba.Instance.CajaColocadaEnCarga(other.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Caja"))
        {
            SimuladorPrueba.Instance.CajaColocadaEnCarga(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Caja"))
        {
            SimuladorPrueba.Instance.CajaQuitadaDeCarga(other.gameObject);
        }
    }
}
