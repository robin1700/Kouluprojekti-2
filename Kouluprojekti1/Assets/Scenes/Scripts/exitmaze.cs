using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitmaze : MonoBehaviour
{

    public GameObject Item;
    public GameObject Item2;
    public GameObject Item3;
    public GameObject Item4False;
    public GameObject Item5false;
    public GameObject Item6false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {

            
            Item2.SetActive(true);
            Item.SetActive(true);
            Item3.SetActive(true);
            Item5false.SetActive(false);
            Item4False.SetActive(false);
            Item6false.SetActive(false);
        }
    }
}

