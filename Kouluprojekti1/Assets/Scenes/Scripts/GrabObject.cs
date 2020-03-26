using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObject : MonoBehaviour
{
    float Yrot;
    RaycastHit hit;
    GameObject grabbedObj;
    public Transform grabPos;

    void Update()
    {
    Yrot -= Input.GetAxis("Mouse Y");
    Yrot = Mathf.Clamp(Yrot, -60, 60);
        transform.localRotation = Quaternion.Euler(Yrot, 0, 0);
        if (Input.GetKeyDown("e") && Physics.Raycast(transform.position, transform.forward, out hit, 5) && hit.transform.GetComponent<Rigidbody>()  )
        {
            grabbedObj = null;
        }

        if (grabbedObj)
        {
            grabbedObj.GetComponent<Rigidbody>().velocity = 10 * (grabPos.position - grabbedObj.transform.position);
        }

    }
}
