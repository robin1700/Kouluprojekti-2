using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    public Animator anim1;
    // Start is called before the first frame update
    void Start()
    {
        anim1= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other1)
    {
        if (other1.tag == "Avain2" )
        {
            anim1.Play("Key");
        }
    }
}
