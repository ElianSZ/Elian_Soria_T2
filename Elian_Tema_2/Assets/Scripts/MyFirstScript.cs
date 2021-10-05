using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
    public int playerAge = 35;
    private float playerSpeed = 5.25f;
    [SerializeField] private bool gameOver = false;
    */

    public string playerName = "Elian";
    public string enemyName = "Elian ";

    [SerializeField] private int x = 5;
    [SerializeField] private int y = 3;
    [SerializeField] private int z = 3;

    [SerializeField] private bool isRaining;


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
       */

        if (playerName == enemyName)
        {
            Debug.Log(message: "Player y enemigo se llaman igual");
        }

        if (playerName != enemyName)
        {
            Debug.Log(message: "Player y enemigo tienen distinto nombre");
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (isRaining)
        {
            Debug.Log(message: "Llevate un paraguas");
        }
    }
}
