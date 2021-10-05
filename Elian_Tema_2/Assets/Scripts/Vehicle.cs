using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    // La variable sound guarda el sonido que hace el vehículo
    [SerializeField] private string sound = "¡Brum, brum!";

    // La variable name guarda a que vehiculo se refiere y la varible numberWheels guarda el numero de ruedas que tiene el vehiculo
    [SerializeField] private string name = "";
    [SerializeField] private int numberWheels = 4;

    // La variable hasSiren guarda la sirena
    public bool hasSiren;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message: $"{name} tiene {numberWheels} ruedas y hace {sound}");

        // El operador de decision comprueba si el vehiculo tiene sirena
        if (hasSiren == true)
        {
            Debug.Log(message: $"{name} tiene sirena");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
