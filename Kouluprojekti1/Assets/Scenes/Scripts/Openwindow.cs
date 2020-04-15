using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Openwindow : MonoBehaviour
{
    public Animator anim;
    public AudioSource Windowaudio;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnTriggerStay(Collider plyr)
    {
        if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            anim.Play("WindowRise");
            Windowaudio.Play();
        }
    }
}
