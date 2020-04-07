using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scri : MonoBehaviour
{

    public GameObject Item;
    public GameObject Item2;
    public GameObject Item3;
    public GameObject Item4;
    public GameObject Item5;
    private bool on = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider plyr)
    {
   
            Item.SetActive(true);
            on = true;
            Item2.SetActive(true);
            on = true;
            Item3.SetActive(true);
            on = true;
            Item4.SetActive(true);
            on = true;
            Item5.SetActive(true);
            on = true;
               
    }


}
