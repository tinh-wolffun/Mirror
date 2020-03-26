using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizePosition : MonoBehaviour
{
    public Transform childS;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(
            Random.Range(-4f, 4f), Random.Range(-4f, 4f), 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.up*3;
            childS.position = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.down*3;
            childS.position = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left*3;
            childS.position = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right*3;
            childS.position = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), 0);
        }

    }
}
