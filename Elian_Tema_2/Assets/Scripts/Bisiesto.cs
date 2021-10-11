using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bisiesto : MonoBehaviour
{
    public int year = 2016;

    // Start is called before the first frame update
    void Start()
    {
        if (year % 4 == 0)
        {
            Debug.Log(message: $"El año {year} es bisiesto");
        }
        else
        {
            Debug.Log(message: $"El año {year} no es un año bisiesto");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
