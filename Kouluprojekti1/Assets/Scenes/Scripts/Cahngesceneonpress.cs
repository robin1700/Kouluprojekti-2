using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cahngesceneonpress : MonoBehaviour
{

    public GameObject Item;
    public GameObject Item2;
    public GameObject Item3;
    public GameObject Item4;
    public GameObject Item5false;
    public GameObject Item6false;
    private bool on = false;


    // Start is called before the first frame update
    void Start()
    {
       // && Input.GetKeyDown(KeyCode.E)
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.F))
        //{
        //    Item6false.SetActive(true);
        //    on = true;
        //    Item5false.SetActive(true);
        //    on = true;
        //    Item.SetActive(false);
        //    on = false;
        //    Item2.SetActive(false);
        //    on = false;
        //    Item3.SetActive(false);
        //    on = false;
        //    Item4.SetActive(false);
        //    on = false;



        //}
    }
    void OnTriggerStay(Collider plyr)
    {

        if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            Item6false.SetActive(false);
            on = false;
            Item5false.SetActive(false);
            on = false;
            Item.SetActive(true);
            on = true;
            Item2.SetActive(true);
            on = true;
            Item3.SetActive(true);
            on = true;
            Item4.SetActive(true);
            on = true;


      
        }

        


    }

}
