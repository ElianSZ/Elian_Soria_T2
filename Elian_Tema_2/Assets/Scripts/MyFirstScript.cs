using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
        private float playerSpeed = 5.25f;
    [SerializeField] private bool gameOver = false;

    public int playerAge = 35;

    public string enemyName = "Elian ";

    [SerializeField] private int z = 3;

    [SerializeField] private bool isRaining;
    [SerializeField] private bool isCold;

    // [SerializeField] private int playerHP = 10;
    */

    public string playerName = "Ivan";
    [SerializeField] private int x = 5;
    [SerializeField] private int y = 3;


    // Start is called before the first frame update
    void Start()
    {
        // transform.position = new Vector3(x: 0, y: 0, z: 0);
        transform.position = Vector3.zero;

        HelloWorld();
        HelloName("Elian");
        HelloName(playerName);
        Debug.Log(message: GetHello());
        Debug.Log(message: $"{x} + {y} = {Sum(x, y)}");


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
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position -= Vector3.right;
            // transform.position += Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += Vector3.up;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position -= Vector3.up;
            // transform.position += Vector3.down;
        }
        */


        /*
        if (isRaining == true || isCold == true)
        {
            Debug.Log(message: "Llevate un paraguas y una sudadera");
        }
        else
        {
            Debug.Log(message: "No llueve y no hace frio");
        }

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
        */

        MoveGameObject(Vector3.right, KeyCode.D);
        MoveGameObject(Vector3.left, KeyCode.A);
        MoveGameObject(Vector3.up, KeyCode.E);
        MoveGameObject(Vector3.down, KeyCode.Q);
        MoveGameObject(Vector3.forward, KeyCode.W);
        MoveGameObject(Vector3.back, KeyCode.S);
    }
    public void HelloWorld()
    {
        Debug.Log(message: "¡Hola, mundo!");
    }

    public void HelloName(string name)
    {
        Debug.Log(message: $"Hola, {name}");
    }

    public string GetHello()
    {
        return "Hola";
    }

    public int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    public void MoveGameObject(Vector3 direction, KeyCode keyCode)
    {
        if (Input.GetKeyDown(keyCode))
        {
            transform.position += direction;
        }
    }
}
