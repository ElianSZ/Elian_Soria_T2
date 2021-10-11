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

    [SerializeField] private bool isOn = true;

    [SerializeField] private float gasoline;


    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log(message: $"{name} tiene {numberWheels} ruedas y hace {sound}");

        // El operador de decision comprueba si el vehiculo tiene sirena
        if (hasSiren == true)
        {
            Debug.Log(message: $"{name} tiene sirena");
        }
        else
        {
            Debug.Log(message: $"{name} no tiene sirena");
        }
        */

        // El else indica que todo lo anterior es falso
        if (isOn == true)
        {
            Debug.Log(message: $"{sound}");
        }
        else if (hasSiren == true)
        {
            Debug.Log(message: $"{name} hará {sound} cuando se ponga en marcha");
        }
        else
        {
            Debug.Log(message: $"{name} no esta en marcha");
        }
        
        /*
        if (gasoline < 10 && isOn == true)
        {
            Debug.Log(message: $"¡A {name} le queda poca gasolina!");
        }
        */

        if (isOn == true)
        {
            if (gasoline < 10)
            {
                Debug.Log(message: $"¡A {name} le queda poca gasolina!");
            }
            if (hasSiren == true)
            {
                Debug.Log(message: $"{sound}");
            }
            else
            {
                Debug.Log(message: $"{name} no tiene sirena.");
            }
        }
        else
        {
            Debug.Log(message: $"{name} no esta en marcha.");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
