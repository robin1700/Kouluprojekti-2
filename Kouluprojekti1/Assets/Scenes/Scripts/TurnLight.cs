using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight : MonoBehaviour
{

    public GameObject light;
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject light5;
    private bool on = false;
    bool IsPlayerIn;

    private void Update()
    {
        if (IsPlayerIn)
        {

            if (Input.GetKeyDown(KeyCode.E) && !on)
            {
                light.SetActive(true);
                on = true;
                light1.SetActive(true);
                on = true;
                light2.SetActive(true);
                on = true;
                light3.SetActive(true);
                on = true;
                light4.SetActive(true);
                on = true;
                light5.SetActive(true);
                on = true;
            }
            else if (Input.GetKeyDown(KeyCode.E) && on)
            {
                light.SetActive(false);
                on = false;
                light2.SetActive(false);
                on = false;
                light3.SetActive(false);
                on = false;
                light4.SetActive(false);
                on = false;
                light1.SetActive(false);
                on = false;
                light5.SetActive(false);
                on = false;
            }
        }
    }

    // Use this for initialization
    void OnTriggerEnter(Collider plyr)
    {

        if (plyr.tag == "Player")
        {
            IsPlayerIn = true;

        }
    }
    void OnTriggerExit(Collider plyr)
    {

        if (plyr.tag == "Player")
        {
            IsPlayerIn = false;

        }
    }
}
