using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
        private float playerSpeed = 5.25f;
    [SerializeField] private bool gameOver = false;

    public int playerAge = 35;

    public string playerName = "Elian";
    public string enemyName = "Elian ";

    [SerializeField] private int x = 5;
    [SerializeField] private int y = 3;
    [SerializeField] private int z = 3;
    */

    [SerializeField] private bool isRaining;
    [SerializeField] private bool isCold;

    // [SerializeField] private int playerHP = 10;


    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log(playerAge);
        Debug.Log(message: $"¡Hola {playerName}!");
        */

        /*
        Debug.Log(message: $"Suma: {x} + {y} = {x + y}");
        Debug.Log(message: string.Format("Resta: {0} - {1} = {2}", x, y, x - y));
        Debug.Log(message: string.Format("Producto: {0} * {1} = {2}", x, y, x * y));
        Debug.Log(message: string.Format("Division: {0} / {1} = {2}", x, y, x / y));
       

        if (playerName == enemyName)
        {
            Debug.Log(message: "Player y enemigo se llaman igual");
        }

        if (playerName != enemyName)
        {
            Debug.Log(message: "Player y enemigo tienen distinto nombre");
        }
        

        if (playerHP > 0)
        {
            Debug.Log(message: "Sigues vivo.");
        }
        else
        {
            Debug.Log(message: "Estas muerto.");
        }

        if (playerAge < 13)
        {
            Debug.Log(message: "Eres un niño");
        }
        else if (playerAge < 18)
        {
            Debug.Log(message: "Eres adolescente");
        }
        else
        {
            Debug.Log(message: "Eres adulto");
        }
        */


    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (isRaining == true || isCold == true)
        {
            Debug.Log(message: "Llevate un paraguas y una sudadera");
        }
        else
        {
            Debug.Log(message: "No llueve y no hace frio");
        }
        */

        if (isRaining == true)
        {
            if (isCold)
            {
                Debug.Log(message: "Lleva un paraguas y una sudadera");
            }
            else
            {
                Debug.Log(message: "Lleva un paraguas");
            }
        }
        else
            {
                Debug.Log(message: "No llueve");
            }
    }
}
