using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kakkaa : MonoBehaviour
{
    public GameObject esine;
    public GameObject esine2;
    public GameObject esine3;
    public GameObject esine4;
    public GameObject esine5;


    private bool on = false;
    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.tag == "Respawn")
        {

            Destroy(esine3);
            Destroy(esine5);
            esine.SetActive(true);
            esine4.SetActive(true);
            esine2.SetActive(true);
        }


    }
}
