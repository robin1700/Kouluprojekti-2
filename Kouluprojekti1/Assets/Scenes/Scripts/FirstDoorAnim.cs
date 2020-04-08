﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstDoorAnim : MonoBehaviour
{
    public Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnTriggerStay(Collider Key)
    {
        if (  Key.tag == "Avain2"   )
        {
            anim.Play("Door1");
        }
        if (Key.tag == "Key")
        {
            anim.Play("Door1");
        }

    }
}
