using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kakkaa : MonoBehaviour
{
    public GameObject esine;
    public GameObject esine2;
    public GameObject esine3;
    private bool on = false;
    void OnTriggerStay(Collider plyr)
    {
         Destroy(esine3);
        esine.SetActive(true);
        on = true;
        esine2.SetActive(true);
        on = true;
       
    }
}
