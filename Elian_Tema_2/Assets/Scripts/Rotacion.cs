using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateGameObject(KeyCode.RightArrow, new Vector3(x: 0, y: 10, z: 0));
        RotateGameObject(KeyCode.UpArrow, new Vector3(x: 10, y: 0, z: 0));

        /*
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation *= Quaternion.Euler(x: 0, y: 10, z: 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation *= Quaternion.Euler(x: 0, y: -10, z: 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.rotation *= Quaternion.Euler(x: 10, y: 0, z: 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.rotation *= Quaternion.Euler(x: -10, y: 0, z: 0);
        }
        */

        void RotateGameObject(KeyCode kCode, Vector3 rotation)
        {
            if (Input.GetKeyDown(kCode))
            {
                transform.rotation *= Quaternion.Euler(rotation);
            }
        }
    }
}
