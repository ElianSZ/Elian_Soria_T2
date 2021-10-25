using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatataCaliente : MonoBehaviour
{
    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = Random.Range(7, 16);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        counter -= 1;
            if (counter <= 0)
        {
            Destroy(gameObject);
        }

        transform.localScale += 1 * Vector3.one;
        // transform.localScale += new Vector3(1, 1, 1);
    }
}
