using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight1 : MonoBehaviour
{

    public GameObject light1;
    public GameObject light11;
    public GameObject light12;
    public GameObject light13;
    public GameObject light14;
    public GameObject light15;
    private bool on = false;
    bool IsplayerIn;



    void Start()
    {

    }

    void Update()
    {
        if (IsplayerIn)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                light1.SetActive(true);
                on = true;
                light11.SetActive(true);
                on = true;
                light12.SetActive(true);
                on = true;
                light13.SetActive(true);
                on = true;
                light14.SetActive(true);
                on = true;
                light15.SetActive(true);
                on = true;

            }
        }
    }

    // Use this for initialization
    void OnTriggerEnter(Collider plyr)
    {

        if (plyr.tag == "Player")
        {
            IsplayerIn = true;

        }
    }
    void OnTriggerExit(Collider plyr)
    {

        if (plyr.tag == "Player")
        {
            IsplayerIn = false;

        }
    }


}