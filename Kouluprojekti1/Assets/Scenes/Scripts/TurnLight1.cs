using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight1 : MonoBehaviour {

    public GameObject light1;
    public GameObject light11;
    public GameObject light12;
    public GameObject light13;
    public GameObject light14;
    public GameObject light15;
    private bool on = false;
    


        void Start()
        {
        
        }

    // Use this for initialization
    void OnTriggerStay(Collider plyr) {
        if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E) && !on)
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
        else if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E) && on)
            {
            light1.SetActive(false);
            on = false;
            light12.SetActive(false);
            on = false;
            light13.SetActive(false);
            on = false;
            light14.SetActive(false);
            on = false;
            light11.SetActive(false);
            on = false;

        }
    }
}