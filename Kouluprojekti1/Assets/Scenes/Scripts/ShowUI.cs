
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour
{

    public GameObject uiObject;
    bool IsPlayerIn;
    void Start()
    {
        uiObject.SetActive(false);
    }

    private void Update()
    {
        if (IsPlayerIn)
        {
            uiObject.SetActive(true);
        }
        else
        {
            uiObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider player)
    {
        if (player.tag == "Player")
        {
            IsPlayerIn = true;
        }

    }

    void OnTriggerExit(Collider player)
    {
        if (player.tag == "Player")
        {
            IsPlayerIn = false;
        }

    }



}