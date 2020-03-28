using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotateobject : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
            transform.Rotate(Vector3.left * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
            transform.Rotate(-Vector3.left * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(-Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
            Application.LoadLevel(Application.loadedLevel);

    }
}
