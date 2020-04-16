using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Openwindow : MonoBehaviour
{
    public Animator anim;
    public AudioSource Windowaudio;
    bool isPlayerIn;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (isPlayerIn)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.Play("WindowRise");
                Windowaudio.Play();
            }
        }
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.tag == "Player")
        {
            isPlayerIn = true;
        }

    }

    void OnTriggerExit(Collider plyr)
    {
        if (plyr.tag == "Player")
        {
            isPlayerIn = false;
        }
    }

}
