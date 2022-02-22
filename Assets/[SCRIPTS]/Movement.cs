using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {

            transform.Translate(1 * speed * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey(KeyCode.A))
        {

            transform.Translate(-1 * speed * Time.deltaTime, 0, 0);

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            transform.Translate(0, 3, 0 * Time.deltaTime * speed);

        }
    }
}
