using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTheNumber : MonoBehaviour
{
    private int randNum;
    [SerializeField] private int num;
    [SerializeField] private int counter;

    // Start is called before the first frame update
    void Start()
    {
        // El ultimo número no se cuenta, si quiero hasta el 10, pongo un 11
        randNum = Random.Range(1, 11);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            num = int.Parse(GetComponent<InputField>().text);
        }

        if (num > randNum)
        {
            Debug.Log(message: "El número que has puesto es mayor.");
        }
        else if (num == randNum)
        {
            Debug.Log(message: "¡Has acertado!");
            Debug.Log(message: $"Intentos: {counter}");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log(message: "El número que has puesto es menor.");
        }

        counter += 1;
    }
}
