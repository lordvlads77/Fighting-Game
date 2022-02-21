using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {

            transform.Translate(1, 0, 0 * Time.deltaTime * speed);

        }

        if (Input.GetKey(KeyCode.A))
        {

            transform.Translate(1, 0, 0 * Time.deltaTime * speed);

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            transform.Translate(0, 1, 0 * Time.deltaTime * speed);

        }
    }
}
