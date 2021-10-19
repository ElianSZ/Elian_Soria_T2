using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Par : MonoBehaviour
{
    public int num = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            num = int.Parse(GetComponent<InputField>().text);
            SerPar(num);
        }
    }

    public void SerPar(int num)
    {
        if (num % 2 == 0)
        {
            if (num % 100 == 0)
            {
                if (num % 400 == 0)
                {
                    Debug.Log(message: $"El número {num} es par");
                }
                else
                {
                    Debug.Log(message: $"El número {num} es impar");
                }
            }
            else
            {
                Debug.Log(message: $"El número {num} es par");
            }
        }
        else
        {
            Debug.Log(message: $"El número {num} es impar");
        }
    }
}
